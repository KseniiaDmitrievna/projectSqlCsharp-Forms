using OfficeOpenXml.Drawing.Style.Effect;
using System;
using System.Data;
using System.Windows.Forms;

namespace kursah
{
    public partial class FormAttestation : System.Windows.Forms.Form
    {
        public FormAttestation()
        {
            InitializeComponent();
        }
        Show show = new Show();
        Edit edit = new Edit();
        private void FormAttestation_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActiveForm.Hide();
        }

        private void FormAttestation_Load(object sender, EventArgs e)
        {
            updateShow();
            apdate();
        }

        public void updateShow()
        {

            string sql = "SELECT a.Id_Аттистации, a.Профиль, d.Название_Дисциплины, a.ЗачетнаяКнижка, s.Фамилия,  a.Id_Преподавателя, p.Фамилия, a.Зачет, a.Экзамен, a.Курсовая, a.Реферат, a.Ргр, a.Практика, a.Рр " +
                 "FROM Аттестация a " +
                 "INNER JOIN Студенты s ON  a.ЗачетнаяКнижка = s.ЗачетнаяКнижка " +
                 "INNER JOIN Преподаватели p ON p.Id_Преподавателя = a.Id_Преподавателя " +
                 "INNER JOIN Учебный_План u ON a.Профиль = u.Профиль " +
                 "INNER JOIN Дисциплины d ON u.Индекс_Дисциплины = d.Индекс_Дисциплины " ;

            dataGridView1.DataSource = show.attest(sql);
            dataGridView1.Columns[0].HeaderCell.Value = "№";
            dataGridView1.Columns[2].HeaderCell.Value = "Дисциплина";
            dataGridView1.Columns[3].HeaderCell.Value = "Зачетная книжка";
            dataGridView1.Columns[4].HeaderCell.Value = "Фамилия студента";
            dataGridView1.Columns[5].HeaderCell.Value = "ID преподавателя";
            dataGridView1.Columns[6].HeaderCell.Value = "Фамилия преподавателя";

        }
        public void apdate()
        {
            try
            {
                DataTable datatableIDPr = edit.fillId("SELECT Id_Преподавателя, Фамилия, Имя, Отчество FROM Преподаватели ORDER BY Фамилия");
                DataTable datatableIDSt = edit.fillId("SELECT ЗачетнаяКнижка , Фамилия, Имя, Отчество FROM Студенты WHERE Номер_Группы = '"+comboBoxGr.Text+ "'  ORDER BY Фамилия ");
                DataTable dataTableGr = edit.fillId("SELECT Номер_группы FROM Группы ");
                comboBoxGr.DataSource = dataTableGr;
                comboBoxGr.DisplayMember = "Номер_группы";

                if (datatableIDPr != null | datatableIDSt != null)
                {
                    datatableIDSt.Columns.Add("Студент", typeof(string));
                    foreach (DataRow row in datatableIDSt.Rows) 
                    {
                        string combinedValue = row["ЗачетнаяКнижка"].ToString() + " " + row["Фамилия"].ToString() +" " + row["Имя"].ToString() + " " + row["Отчество"].ToString();
                        row["Студент"] = combinedValue;
                    }
                    comboBoxSt.DataSource = datatableIDSt;
                    comboBoxSt.DisplayMember = "Студент";

                    datatableIDPr.Columns.Add("Преподаватель", typeof(string));
                    foreach (DataRow row in datatableIDPr.Rows)
                    {
                        string combinedValue = row["Id_Преподавателя"].ToString() + " " + row["Фамилия"].ToString() + " " + row["Имя"].ToString() + " " + row["Отчество"].ToString();
                        row["Преподаватель"] = combinedValue;
                    }
                    comboBoxPr.DataSource = datatableIDPr;
                    comboBoxPr.DisplayMember = "Преподаватель";
                }
                else { MessageBox.Show("В базе нет категорий. Добавьте её!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибкаi!"); }
        }

        private void buttonSendAtt_Click(object sender, EventArgs e)
        {
            try
            { 
                string st = Box1.Text + Box2.Text + Box3.Text + Box4.Text + Box5.Text + Box6.Text + Box6.Text + Box7.Text;
                if (st.Contains("6")| st.Contains("7") | st.Contains("8")| st.Contains("9")) 
                { 
                    MessageBox.Show("Некорректная оценка!", "Внимание!");
                }
                if (string.IsNullOrEmpty(Box1.Text) & string.IsNullOrEmpty(Box2.Text) & string.IsNullOrEmpty(Box3.Text) 
                    & string.IsNullOrEmpty(Box4.Text) & string.IsNullOrEmpty(Box5.Text) & string.IsNullOrEmpty(Box6.Text) & string.IsNullOrEmpty(Box7.Text)) 
                {
                    MessageBox.Show("Введите хотя бы одну оценку", "Внимание!");
                }
                else
                {
                    string[] stud = comboBoxSt.Text.Split(' ');
                    string[] prep = comboBoxPr.Text.Split(' ');
                    string[] prof = comboBoxProfil.Text.Split(' ');

                    edit.insertData(prof[0].ToString(), stud[0].ToString(),
                    prep[0].ToString(), Box1.Text, Box2.Text, Box3.Text, Box4.Text, Box5.Text, Box6.Text, Box7.Text);
                }
                updateShow();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = show.tableDisplay("Аттестация");
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                show.saveDate("Аттестация");
            }
            catch (InvalidCastException ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

        private void comboBoxSt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] stud = comboBoxSt.Text.Split(' ');
            DataTable datatableProfil = edit.fillId("SELECT u.Профиль , d.Название_Дисциплины " +
                 "FROM Учебный_план u " +
                 " INNER JOIN Группы g ON  u.Специальность = g.Код_Специальности " +
                 " INNER JOIN Студенты s ON (g.Номер_Группы = s.Номер_Группы AND s.ЗачетнаяКнижка = '" + stud[0] +"') " +
                 " INNER JOIN Дисциплины d ON u.Индекс_Дисциплины = d.Индекс_Дисциплины");
             
            datatableProfil.Columns.Add("Профиль1", typeof(string));
            foreach (DataRow row in datatableProfil.Rows)
            {
                string combinedValue = row["Профиль"].ToString() + " " + row["Название_Дисциплины"].ToString();
                row["Профиль1"] = combinedValue;
            }
            comboBoxProfil.DataSource = datatableProfil;
            comboBoxProfil.DisplayMember = "Профиль1";

        }

        private void comboBoxGr_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            apdate();
        }
    }
}
