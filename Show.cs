
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace kursah
{
    internal class Show
    {
        public Show()
        {
            
        }
        SqlConnection sqlConnection = new SqlConnection
       (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bazaCours.mdf;Integrated Security=True;Connect Timeout=30");
       SqlDataAdapter sqlDataAdapter = null;
        public DataTable tableDisplay(string tableName)
        {
            string sql = "SELECT * FROM " + tableName; 
            return dataTable(sql);
        }

        public DataTable attest(string sql) 
        {
            return dataTable(sql);
        }

        DataSet dataset = null;
        public DataTable dataTable(string sql)
        {
            sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            sqlDataAdapter.Update(dataset);
            return dataset.Tables[0];
        }
        public void saveDate(string tableName)
        {
           try
           {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableName, sqlConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();
                sqlDataAdapter.Update(dataset);
                MessageBox.Show("Данные обновились!", "Внимание");
           }
            catch (SqlException ex)
            {
                if (ex.Number == 547) 
                {
                    MessageBox.Show("Ошибка удаления данных: нарушение ограничений внешнего ключа.");
                }
                else
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
        public bool proverka(string number)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT( * ) FROM Аттестация WHERE  ЗачетнаяКнижка = '" + number + "'", sqlConnection);
            int numCmd = (int)cmd.ExecuteScalar();
            sqlConnection.Close();
            if (numCmd > 0) {return true; }
            else { return false; }
        }
        public DataTable poisk(string number) 
        {
            string sql = "SELECT Название_Дисциплины,Преподаватели.Фамилия ,Зачет, Экзамен, Курсовая, Реферат, Ргр, Практика, Рр " +
                        "FROM Аттестация, Дисциплины, Учебный_План, Преподаватели " +
                        "WHERE  ЗачетнаяКнижка = '" + number + "' and  Дисциплины.Индекс_Дисциплины = Учебный_План.Индекс_Дисциплины and Аттестация.Профиль = Учебный_План.Профиль and Аттестация.Id_Преподавателя = Преподаватели.Id_Преподавателя ";
            return dataTable(sql);
               
        }

        public DataTable poiskName(string number)
        {
            string sql = "SELECT Фамилия, Имя, Отчество FROM Студенты WHERE ЗачетнаяКнижка = '"+number+"'";
            return dataTable(sql);
        }

        public DataTable othet(string zach, string exz, string oc, string prof, string prep)
        {
            int i = 0;
           try
           {
            string sql = "SELECT a.Id_Аттистации, a.Профиль, d.Название_Дисциплины, a.ЗачетнаяКнижка, s.Фамилия,  a.Id_Преподавателя, p.Фамилия, a.Зачет, a.Экзамен, a.Курсовая, a.Реферат, a.Ргр, a.Практика, a.Рр " +
                  "FROM Аттестация a " +
                  "INNER JOIN Студенты s ON  a.ЗачетнаяКнижка = s.ЗачетнаяКнижка " +
                  "INNER JOIN Преподаватели p ON p.Id_Преподавателя = a.Id_Преподавателя " +
                  "INNER JOIN Учебный_План u ON a.Профиль = u.Профиль " +
                  "INNER JOIN Дисциплины d ON u.Индекс_Дисциплины = d.Индекс_Дисциплины " +
                  "WHERE ";


            
            if (prof != "Не выбрано")
                {
                    sql = sql + " (a.Профиль = '" + prof + "') ";
                    i++;
                }
                if (zach != "Не выбрано")
                {
                    if (i > 0)
                    {
                        sql = sql + " OR  ( a.ЗачетнаяКнижка = '" + zach + "') ";
                        i++;
                    }
                    else
                    {
                        sql = sql + " ( a.ЗачетнаяКнижка = '" + zach + "')";
                        i++;
                    }

                }
                if (prep != "Не выбрано")
                {
                    if (i > 0)
                    {
                        sql = sql + " OR( a.Id_Преподавателя = '" + prep + "')";
                        i++;
                    }

                    else
                    {
                        sql = sql + " ( a.Id_Преподавателя = '" + prep + "') ";
                        i++;
                    }

                }
                if (exz != "Не выбрано" && oc != "")
                {
                    if (i > 0)
                    {

                        sql = sql + " OR " + "(  [" + exz + "] = '" + oc + "')";
                    }
                    else
                    {
                        sql = sql + "(  [" + exz + "] = '" + oc + "')";
                    }

                }
                if (prof == "Не выбрано" & prep == "Не выбрано" & (exz == "Не выбрано" | oc == null))
                {
                    MessageBox.Show("Выберите критерии!");
                    return dataTable("SELECT * FROM Аттестация");
                }
                else
                {
                    return dataTable(sql);
                }
           }
           catch (Exception ex) { MessageBox.Show(ex.Message, "Вниманий!"); return dataTable("SELECT * FROM Аттестация"); }

        }
       
    }  
}
