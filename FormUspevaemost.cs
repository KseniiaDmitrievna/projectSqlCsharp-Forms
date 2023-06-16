using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace kursah
{
    public partial class FormUspevaemost : System.Windows.Forms.Form
    {
        public FormUspevaemost()
        {
            InitializeComponent();
        }
        Edit edit = new Edit();

        private void FormUspevaemost_Load(object sender, EventArgs e)
        {
            showCombo();
        }
        private void showCombo()
        {
            string sql = "SELECT Название_Факультета FROM Факультет";
            comboBoxFak.DataSource = edit.fillId(sql);
            comboBoxFak.DisplayMember = "Название_Факультета";
        }
        private void comboBoxFak_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fakultet = comboBoxFak.Text;
            DataTable dt = edit.fillId("SELECT Код_Специальности, Название_Специальности " +
                "FROM Специальность, Факультет " +
                "WHERE Специальность.Название_Факультета = Факультет.Название_Факультета AND Факультет.Название_Факультета = '" + fakultet + "' ");

            dt.Columns.Add("Специальности", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                string combinedValue = row["Код_Специальности"].ToString() + " " + row["Название_Специальности"].ToString();
                row["Специальности"] = combinedValue;
            }
            comboBoxSp.DataSource = dt;
            comboBoxSp.DisplayMember = "Специальности";

        }

        private void comboBoxSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] sp = comboBoxSp.Text.Split(' ');
            DataTable datatableGr = edit.fillId("SELECT Номер_Группы " +
                 "FROM Группы g " +
                 "WHERE Код_Специальности =  '" + sp[0] + "'  ");

            comboBoxGruppa.DataSource = datatableGr;
            comboBoxGruppa.ValueMember = "Номер_Группы";
            comboBoxGruppa2.DataSource = datatableGr;
            comboBoxGruppa2.ValueMember = "Номер_Группы";

        }
   
        private void buttonSt_Click(object sender, EventArgs e)
        {
            try
            {
                string[] st = comboBoxSt.Text.Split(' ');
                DataTable dt = edit.fillId("SELECT s.ЗачетнаяКнижка, s.Фамилия, s.Имя, s.Отчество, s.Номер_Группы " +
                    " FROM Студенты s " +
                    " WHERE s.ЗачетнаяКнижка = '" + st[0] + "' ");

                DataTable dtOc = edit.fillId("SELECT d.Название_Дисциплины, a.Id_Преподавателя, p.Фамилия, a.Зачет, a.Экзамен, a.Курсовая, a.Реферат, a.Ргр, a.Практика, a.Рр " +
                 "FROM Аттестация a " +
                 "INNER JOIN Студенты s ON  a.ЗачетнаяКнижка = s.ЗачетнаяКнижка AND s.ЗачетнаяКнижка =  '" + st[0] + "'" +
                 "INNER JOIN Преподаватели p ON p.Id_Преподавателя = a.Id_Преподавателя " +
                 "INNER JOIN Учебный_План u ON a.Профиль = u.Профиль " +
                 "INNER JOIN Дисциплины d ON u.Индекс_Дисциплины = d.Индекс_Дисциплины ORDER BY Фамилия");
                dataGridView1.DataSource = dtOc;

                dataGridView1.Columns[0].HeaderCell.Value = "Дисциплина";
                dataGridView1.Columns[1].HeaderCell.Value = "ID преподавателя";
                dataGridView1.Columns[2].HeaderCell.Value = "Фамилия преподавателя";
              
                string text = "";
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        text += row[column].ToString() + " ";
                    }

                    text += Environment.NewLine;
                }

                textBox1.Text = text; stRow(dtOc);
               
            }
            catch { MessageBox.Show("У этого студента нет оценок", "Ой!"); }
        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application ExcelApp = new Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                Excel.Worksheet worksheet = (Excel.Worksheet)ExcelApp.ActiveSheet;

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }

                ExcelApp.Visible = true;



            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }


        }

        private void buttonPr_Click(object sender, EventArgs e)
        {
            string[] pr = comboBoxPrep.Text.Split(' ');
            DataTable dt = edit.fillId("SELECT Id_Преподавателя, Фамилия, Имя, Отчество " +
                "FROM Преподаватели " +
                "WHERE Id_Преподавателя = '" + pr[0] + "'");

            DataTable dtOc = edit.fillId("SELECT s.ЗачетнаяКнижка, s.Фамилия, s.Имя, a.Зачет, a.Экзамен " + 
                " FROM Аттестация a, Студенты s " +
                "WHERE  a.Id_Преподавателя = '"+ pr[0] + "' AND s.ЗачетнаяКнижка = a.ЗачетнаяКнижка AND s.Номер_Группы = '" + comboBoxGruppa.Text + "' ORDER BY Фамилия ");

            dataGridView1.DataSource = dtOc;


            dataGridView1.Columns[0].HeaderCell.Value = "Зачетная Книжка";
            dataGridView1.Columns[1].HeaderCell.Value = "Фамилия студента";
          
            string text = "";
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    text += row[column].ToString() + " ";
                }

                text += Environment.NewLine;
            }

            textBox1.Text = text;
            stRow(dtOc);

        }

        private void buttonSp_Click(object sender, EventArgs e)
        {
            try
            {
                string[] sp = comboBoxSp.Text.Split(' ');
                DataTable dt = edit.fillId("SELECT Код_Специальности, Название_Специальности " +
                    "FROM Специальность " +
                    "WHERE Название_Специальности = '" + sp[0] + "'");
             
                DataTable dtOc = edit.fillId("SELECT a.ЗачетнаяКнижка, st.Фамилия,st.Имя, st.Номер_Группы ,a.Зачет, a.Экзамен, a.Курсовая, a.Реферат, a.Ргр, a.Практика, a.Рр " +
                     " FROM Аттестация a, Студенты st, Группы g, Специальность sp " +
                     " WHERE  a.ЗачетнаяКнижка = st.ЗачетнаяКнижка" +
                     " AND  g.Номер_группы =  st.Номер_Группы" +
                     " AND  g.Код_Специальности =  sp.Код_Специальности" +
                     " AND  sp.Код_Специальности = '" + sp[0] + "'");
                dataGridView1.DataSource = dtOc;
               

               

                textBox1.Text = dt.ToString(); stRow(dtOc); 
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        

        }

        private void comboBoxGruppa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] sp = comboBoxSp.Text.Split(' ');
            DataTable datatableIDSt = edit.fillId("SELECT s.ЗачетнаяКнижка , s.Фамилия, s.Имя, s.Отчество " +
                " FROM Студенты s " +
                " INNER JOIN Группы g ON s.Номер_Группы = g.Номер_Группы" +
                " INNER JOIN Специальность sp ON g.Код_Специальности = sp.Код_Специальности" +
                " WHERE sp.Код_Специальности = '" + sp[0] + "' AND g.Номер_Группы = '" + comboBoxGruppa2.Text + "' ");

            datatableIDSt.Columns.Add("Студент", typeof(string));
            foreach (DataRow row in datatableIDSt.Rows)
            {
                string combinedValue = row["ЗачетнаяКнижка"].ToString() + " " + row["Фамилия"].ToString() + " " + row["Имя"].ToString() + " " + row["Отчество"].ToString();
                row["Студент"] = combinedValue;
            }
            comboBoxSt.DataSource = datatableIDSt;
            comboBoxSt.DisplayMember = "Студент";
        }

        private void comboBoxGruppa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable datatableIDPr = edit.fillId("SELECT p.Id_Преподавателя, p.Фамилия, p.Имя, p.Отчество " +
                "FROM Преподаватели p " +
                " INNER JOIN Аттестация a ON p.Id_Преподавателя = a.Id_Преподавателя" +
                " INNER JOIN Студенты s ON s.ЗачетнаяКнижка = a.ЗачетнаяКнижка" +
                " INNER JOIN Группы g ON g.Номер_Группы = s.Номер_Группы" +
                " WHERE s.Номер_Группы = '" + comboBoxGruppa.Text + "' "); 
                
            datatableIDPr.Columns.Add("Преподаватель", typeof(string));
            foreach (DataRow row in datatableIDPr.Rows)
            {
                string combinedValue = row["Id_Преподавателя"].ToString() + " " + row["Фамилия"].ToString() + " " + row["Имя"].ToString() + " " + row["Отчество"].ToString();
                row["Преподаватель"] = combinedValue;
            }
            comboBoxPrep.DataSource = datatableIDPr;
            comboBoxPrep.DisplayMember = "Преподаватель";
            
        }

        private void stRow(DataTable dt) 
        {
            int sumExz = 0;
            int sumZach = 0;
            int k = 0; int  k1 = 0;
            foreach (DataRow dr in dt.Rows)
            {
                string value = dr["Экзамен"].ToString();
                string value1 = dr["Зачет"].ToString();
               

                int intValue;
                int intValue1;

                if (int.TryParse(value, out intValue))
                {
                    sumExz += intValue;k++;
                }
                if (int.TryParse(value1, out intValue1))
                {
                    sumZach += intValue1;k1++;
                }
            }
            double v, v1;
            if (k != 0)
            {
                v = sumExz / k;

            }
            else {  v = 0; }
            if (k1 != 0)
            {
                 v1 = sumZach / k1;

            }
            else {  v1 = 0; }

            textBox2.Text = "Средняя оцента по зачету: " + v1.ToString("F") + " Средняя оценка по экзаменам: " + v.ToString("F");
        }

        private void buttonGr_Click(object sender, EventArgs e)
        {
            DataTable dt = edit.fillId("SELECT a.Id_Аттистации, a.Профиль, d.Название_Дисциплины, a.ЗачетнаяКнижка, s.Фамилия,  a.Id_Преподавателя, p.Фамилия, a.Зачет, a.Экзамен, a.Курсовая, a.Реферат, a.Ргр, a.Практика, a.Рр " +
                  "FROM Аттестация a " +
                  "INNER JOIN Студенты s ON  a.ЗачетнаяКнижка = s.ЗачетнаяКнижка " +
                  "INNER JOIN Преподаватели p ON p.Id_Преподавателя = a.Id_Преподавателя " +
                  "INNER JOIN Учебный_План u ON a.Профиль = u.Профиль " +
                  "INNER JOIN Дисциплины d ON u.Индекс_Дисциплины = d.Индекс_Дисциплины " +
                  "WHERE s.Номер_Группы = '" + comboBoxGruppa2.Text + "'");
            textBox1.Text = "";

            dataGridView1.DataSource = dt;

          stRow(dt);

        }
    }
}
