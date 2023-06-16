using System;
using System.Data;
using System.Windows.Forms;

namespace kursah
{
    public partial class FormSpeciality : System.Windows.Forms.Form
    {
        public FormSpeciality()
        {
            InitializeComponent();
        }

        Edit edit = new Edit();

        private void FormSpeciality_Load(object sender, EventArgs e)
        {
            apdate();
        }

        public void apdate()
        {
            try
            {
                DataTable datatableFak = edit.fillId("SELECT Название_Факультета FROM Факультет");
                DataTable datatableKod = edit.fillId("SELECT Код_специальности, Название_Специальности FROM Специальность");
                DataTable datatableDis = edit.fillId("SELECT Индекс_Дисциплины, Название_Дисциплины  FROM Дисциплины");

                if (datatableFak != null | datatableKod != null )
                {
                    comboBoxFak.DataSource = datatableFak;
                    comboBoxFak1.DataSource = datatableFak;

                    comboBoxFak.DisplayMember = "Название_Факультета";
                    comboBoxFak1.DisplayMember = "Название_Факультета";
                

                    datatableKod.Columns.Add("Специальность", typeof(string));
                    foreach (DataRow row in datatableKod.Rows)
                    {
                        string combinedValue = row["Код_специальности"].ToString() + " " + row["Название_Специальности"].ToString();
                        row["Специальность"] = combinedValue;
                    }
                    comboBoxSp.DataSource = datatableKod;
                    comboBoxSp.DisplayMember = "Специальность";
                    comboBoxKod.DataSource = datatableKod;
                    comboBoxKod.DisplayMember = "Специальность";

                    datatableDis.Columns.Add("Дисциплины", typeof(string));
                    foreach (DataRow row in datatableDis.Rows)
                    {
                        string combinedValue = row["Индекс_Дисциплины"].ToString() + " " + row["Название_Дисциплины"].ToString();
                        row["Дисциплины"] = combinedValue;
                    }
                    comboBoxDis.DataSource = datatableDis;
                    comboBoxDis.DisplayMember = "Дисциплины";

                    DataTable dtGr = edit.fillId("SELECT DISTINCT Номер_Группы FROM Студенты");

                    comboBoxPerevodGR.DataSource = dtGr;
                    comboBoxPerevodGR.DisplayMember = "Номер_Группы";


                }
                else { MessageBox.Show("В базе нет категорий. Добавьте её!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Вниманий!"); }
        }

        private void buttonAddSp_Click(object sender, EventArgs e)
        {
            try
            {
                bool isNum = int.TryParse(TextBoxName.Text, out int num);
                bool isNum1 = string.IsNullOrEmpty(TextBoxName.Text);
                bool isNum2 = string.IsNullOrEmpty(TextBoxKod.Text);
                if (isNum | isNum1 | isNum2)
                {
                    //число
                    MessageBox.Show("Проверьте введенные данные! ", "Внимание!");
                }
                else
                {
                    edit.insertData3(TextBoxKod.Text, TextBoxName.Text, comboBoxFak.Text);
                    apdate();
                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Внимание!"); }
        }

        private void buttonAddFak_Click(object sender, EventArgs e)
        {
            try
            {
                bool isNum = int.TryParse(TextBoxFak.Text, out int num);
                bool isNum1 = string.IsNullOrEmpty(TextBoxFak.Text);
                if (isNum | isNum1)
                {
                    //число
                    MessageBox.Show("Проверьте введенные данные! ", "Внимание!");
                
                } 
                else
                {
                    edit.insertData5(TextBoxFak.Text);
                    apdate();
                }

               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Вниманий!"); }
        }

        private void buttonKaf_Click(object sender, EventArgs e)
        {
            try
            {
                bool isNum = int.TryParse(TextBoxKaf.Text, out int num);
                bool isNum1 = int.TryParse(comboBoxFak1.Text, out int num1);

                bool isNum2 = string.IsNullOrEmpty(TextBoxKaf.Text);

                if (isNum | isNum1 | isNum2)
                {
                    MessageBox.Show("Проверьте введенные данные! ", "Внимание!");
                }
                else
                {
                    edit.insertData6(TextBoxKaf.Text, comboBoxFak1.Text);
                    apdate();
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Вниманий!"); }
        }
        private void buttonAddDis_Click(object sender, EventArgs e)
        {
            try
            {

                bool isNum = int.TryParse(TextBoxDisName.Text, out int num);
                bool isNum1 = string.IsNullOrEmpty(TextBoxFak.Text);
                bool isNum2 = string.IsNullOrEmpty(TextBoxDisName.Text);

                if (isNum | isNum1)
                {
                    MessageBox.Show("Проверьте введенные данные! ", "Внимание!");
                }
                
                else
                {
                    edit.insertData7(TextBoxDisId.Text, TextBoxDisName.Text);
                    apdate();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Внимание!"); }
        }
        private void buttonAddPlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TextBoxSem.Text) > 10 | Convert.ToInt32(TextBoxTime.Text) > 1000 
                    | Convert.ToInt32(TextBoxSem.Text) <= 0 | Convert.ToInt32(TextBoxTime.Text) <= 0 
                    | Convert.ToInt32(TextBoxProf.Text) <= 0 | TextBoxSem.Text == " " | TextBoxTime.Text == " ")
                {
                    MessageBox.Show("Проверьте введенные данные! ", "Внимание!");
                }
                else
                {
                    
                        string[] spe = comboBoxSp.Text.Split(' ');
                        string[] dis = comboBoxDis.Text.Split(' ');
                        edit.insertData8(TextBoxProf.Text, spe[0],dis[0], TextBoxTime.Text, TextBoxSem.Text);
                        apdate();
                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

        private void buttonAddGr_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(TextKol.Text) < 0) { MessageBox.Show("Количество студентов не может быть отрицательным!"); }
                if (TextBoxNum.Text == " "| TextKol.Text == " ") { MessageBox.Show("Проверьте введенные данные! ", "Внимание!"); }
                else 
                {
                    string[] spe = comboBoxKod.Text.Split(' ');
                    edit.insertData4(TextBoxNum.Text, TextKol.Text, spe[0]);
                    apdate(); 
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Вниманий!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nameGr = comboBoxPerevodGR.Text;
            bool isNum1 = int.TryParse(textBoxNuGr.Text, out int num1);
            
            if (isNum1 == false)
            {
                MessageBox.Show("Ошибка ввода ", "Внимание!");
            }
            
            else 
            {
                int numberGr = Convert.ToInt32(textBoxNuGr.Text);
                if (numberGr <= 0 | numberGr > 6) { MessageBox.Show("Группа не может быть такой", "Вниманий!"); }
                else
                {
                    string query = "UPDATE Студенты SET Курс = '" + numberGr + "' WHERE Номер_Группы = '" + nameGr + "'";
                    edit.command(query);
                }
            }

        }
    }
}
