using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace kursah
{
    public partial class FormTeacher : System.Windows.Forms.Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }
        Show show = new Show();
        Edit edit = new Edit();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxId.Text) > 0) 
                {
                    bool isNum = textBoxName.Text.Any(char.IsDigit);
                    bool isNum1 = textBoxOt.Text.Any(char.IsDigit);
                    bool isNum2 = textBoxF.Text.Any(char.IsDigit);
                    if (isNum | isNum1 | isNum2 | string.IsNullOrEmpty(textBoxF.Text)|
                        string.IsNullOrEmpty(textBoxName.Text) | textBoxZv.Text.Any(char.IsDigit))

                    {
                        if (Convert.ToInt32(textBoxSt.Text) <=0 ) 
                        {
                            //число
                            MessageBox.Show("Проверьте введенные данные! ", "Внимание!");
                        }
                    }
                    else
                    {
                        edit.insertData1(textBoxId.Text, comboBoxKaf.Text, textBoxF.Text, textBoxName.Text,
                          textBoxOt.Text, textBoxSt.Text, textBoxZv.Text);

                        textBoxId.Clear();
                        textBoxF.Clear();
                        textBoxName.Clear();
                        textBoxOt.Clear();
                        textBoxSt.Clear();
                        textBoxZv.Clear();

                        show1();
                    }

                }
                else { MessageBox.Show("Проверьте поля ", "Ошибка!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            show1();
            apdate();
        }
        public void show1()
        {
            try
            {
                dataGridView1.DataSource = show.tableDisplay("Преподаватели");
                dataGridView1.Columns[0].HeaderCell.Value = "Id преподавателя";
                dataGridView1.Columns[1].HeaderCell.Value = "Кафедра";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Внимание!") ; }
        }
        public void apdate()
        {
            try
            {
                DataTable datatableKaf = edit.fillId("SELECT Наименование_Кафедры FROM Кафедра");
                if (datatableKaf != null)
                {
                    comboBoxKaf.DataSource = datatableKaf;
                    comboBoxKaf.DisplayMember = "Наименование_Кафедры";
                    comboBoxKaf.ValueMember = "Наименование_Кафедры";

                }
                else { MessageBox.Show("В базе нет категорий. Добавьте её!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
    }
}
