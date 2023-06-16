using System;
using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace kursah
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        Edit edit = new Edit();
        Show show = new Show();   
        private void FormOtchet_Load(object sender, EventArgs e)
        {
            apdate();
        }
        public void apdate()
        {
            try
            {
                DataTable datatableProf = edit.fillId("SELECT u.Профиль , d.Название_Дисциплины " +
                 "FROM Учебный_план u " +
                 " INNER JOIN Дисциплины d ON u.Индекс_Дисциплины = d.Индекс_Дисциплины");

                DataTable datatablePrep = edit.fillId("SELECT Id_Преподавателя, Фамилия, Имя, Отчество FROM Преподаватели");
                DataTable datatableZach = edit.fillId("SELECT ЗачетнаяКнижка , Фамилия, Имя, Отчество FROM Студенты");

                if (datatableProf != null | datatablePrep != null)
                {
                    datatableProf.Columns.Add("Профиль1", typeof(string));
                    foreach (DataRow row in datatableProf.Rows)
                    {
                        string combinedValue = row["Профиль"].ToString() + " " + row["Название_Дисциплины"].ToString();
                        row["Профиль1"] = combinedValue;
                    }
                    DataRow emptyRow1 = datatableProf.NewRow();
                    emptyRow1["Профиль1"] = "Не выбрано";
                    datatableProf.Rows.InsertAt(emptyRow1, 0);
                    comboBoxProfil.DataSource = datatableProf;
                    comboBoxProfil.DisplayMember = "Профиль1";

                    datatablePrep.Columns.Add("Преподаватель", typeof(string));
                    foreach (DataRow row in datatablePrep.Rows)
                    {
                        string combinedValue = row["Id_Преподавателя"].ToString() + " " + row["Фамилия"].ToString() + " " + row["Имя"].ToString() + " " + row["Отчество"].ToString();
                        row["Преподаватель"] = combinedValue;
                    }
                    DataRow emptyRow2 = datatablePrep.NewRow();
                    emptyRow2["Преподаватель"] = "Не выбрано";
                    datatablePrep.Rows.InsertAt(emptyRow2, 0);

                    comboBoxPrep.DataSource = datatablePrep;
                    comboBoxPrep.DisplayMember = "Преподаватель";

                    datatableZach.Columns.Add("Студент", typeof(string));
                    foreach (DataRow row in datatableZach.Rows)
                    {
                        string combinedValue = row["ЗачетнаяКнижка"].ToString() + " " + row["Фамилия"].ToString() + " " + row["Имя"].ToString() + " " + row["Отчество"].ToString();
                        row["Студент"] = combinedValue;
                    }
                   
                    DataRow emptyRow3 = datatableZach.NewRow();
                    emptyRow3["Студент"] = "Не выбрано"; 
                    datatableZach.Rows.InsertAt(emptyRow3, 0);

                    comboBoxZach.DataSource = datatableZach;
                    comboBoxZach.DisplayMember = "Студент";

                    comboBoxProfil.ValueMember = "Профиль";
                    comboBoxPrep.ValueMember = "Id_Преподавателя";
                    comboBoxZach.ValueMember = "ЗачетнаяКнижка";

                }
                else { MessageBox.Show("В базе нет категорий. Добавьте её!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Вниманиe!"); }
        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string[] prep = comboBoxPrep.Text.Split(' ');

            string[] stud = comboBoxZach.Text.Split(' ');
            string[] prof = comboBoxProfil.Text.Split(' ');
            DataTable dt = show.othet(stud[0].ToString(), comboBoxEkz.Text, textBoxOcenka.Text, prof[0], prep[0].ToString()); 

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderCell.Value = "№";
            dataGridView1.Columns[2].HeaderCell.Value = "Дисциплина";
            dataGridView1.Columns[3].HeaderCell.Value = "Зачетная книжка";
            dataGridView1.Columns[4].HeaderCell.Value = "Фамилия студента";
            dataGridView1.Columns[5].HeaderCell.Value = "ID преподавателя";
            dataGridView1.Columns[6].HeaderCell.Value = "Фамилия преподавателя";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application ExcelApp = new Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                Excel.Worksheet worksheet = (Excel.Worksheet)ExcelApp.ActiveSheet;

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    ExcelApp.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
                ExcelApp.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
    }
}
