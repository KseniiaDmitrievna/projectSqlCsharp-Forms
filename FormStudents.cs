using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace kursah
{
    public partial class FormStudents : System.Windows.Forms.Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }
        Show show = new Show();
        Edit edit = new Edit();

        private void FormStudents_Load(object sender, EventArgs e)
        {
            try
            {
                show1();
                update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
        public void show1()
        { 
            dataGridView1.DataSource = show.tableDisplay("Студенты");
            dataGridView1.Columns[0].HeaderCell.Value = "Зачетная книжка";
            dataGridView1.Columns[2].HeaderCell.Value = "Группа";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int numberId = Convert.ToInt32(NumberIDTb.Text);

                if (Convert.ToInt32(CourseTb.Text) > 7 | Convert.ToInt32(CourseTb.Text) < 1 |
                    Convert.ToInt32(CourseTb.Text) <= 0 | Convert.ToInt32(CourseTb.Text) <= 0)
                {
                    MessageBox.Show("Неверно заполнены данные! ");
                }
                else
                {
                    if (Convert.ToInt32(NumberIDTb.Text) <= 0) { MessageBox.Show("Номер зачетной книжки не может быть отрицательным!");}
                    if (string.IsNullOrEmpty(NumberIDTb.Text) | string.IsNullOrEmpty(SurNameTb.Text)| 
                        string.IsNullOrEmpty(NameTb.Text) | string.IsNullOrEmpty(CourseTb.Text)) 
                    {
                        MessageBox.Show("Проверьте введенные данные! ", "Внимание!");
                    }
                    else
                    {
                        bool isNum = SurNameTb.Text.Any(char.IsDigit);
                        bool isNum1 = NameTb.Text.Any(char.IsDigit);
                        bool isNum2 = OtchestvoTb.Text.Any(char.IsDigit);
                        if (isNum | isNum1 | isNum2)
                        {
                            //число
                            MessageBox.Show("Вы ввели цифру!", "Внимание!");

                        }
                        else
                        {
                            edit.insertData2(NumberIDTb.Text, SurNameTb.Text, NameTb.Text, OtchestvoTb.Text, CourseTb.Text, GroupCb.Text);
                            show1();
                        }
                    }
                       
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
        public void update()
        {
            try
            {
                DataTable datatableID = edit.fillId("SELECT Номер_Группы FROM Группы");
                if (datatableID != null)
                {
                    GroupCb.DataSource = datatableID;
                    GroupCb.DisplayMember = "Номер_Группы";
                    GroupCb.ValueMember = "Номер_Группы";
                }
                else { MessageBox.Show("В базе нет категорий. Добавьте её!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
    }
}
