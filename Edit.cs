using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static OfficeOpenXml.ExcelErrorValue;

namespace kursah
{
    internal class Edit
    {
        SqlConnection sqlConnection = new SqlConnection
        (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\bazaCours.mdf;Integrated Security=True;Connect Timeout=30");
        SqlDataAdapter sqlDataAdapter = null;
        SqlCommandBuilder sqlCommandBuilder = null;
        DataSet dataset = new DataSet();

        public Edit()
        {
            sqlConnection.Open();
        }
        public void saveDate(string tableName)
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableName, sqlConnection);
                
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlDataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();
                sqlDataAdapter.Update(dataset);

                MessageBox.Show("Данные обновились!", "Внимание");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

        public DataTable fillId(string st)
        {
            string query = st;  
            return dataTable(query);
        }
        public DataTable dataTable(string query)
        {
  
                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                sqlDataAdapter.Update(dt);
                return dt;
            
        }

        public void insertData(string profil, string numberSt, string IdPr, string z, string E, string k, string r, string rgr, string pr, string rr)
        {
           try
           {
                SqlCommand cmd1 = new SqlCommand("SELECT Учебный_план.Семестр, Курс  FROM Учебный_план, Студенты WHERE Студенты.ЗачетнаяКнижка = '" + numberSt + "' AND  Учебный_план.Профиль = '" + profil + "'", sqlConnection);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                sda.Fill(dt);
                int semester = Convert.ToInt32(dt.Rows[0]["Семестр"]);
                int kurs = Convert.ToInt32(dt.Rows[0]["Курс"]);

                SqlCommand cmd2 = new SqlCommand("SELECT Код_Специальности FROM Студенты, Группы WHERE ЗачетнаяКнижка = '" + numberSt + "' AND Студенты.Номер_Группы = Группы.Номер_Группы ", sqlConnection);
                SqlCommand cmd3 = new SqlCommand("SELECT Специальность FROM Учебный_план  WHERE  Учебный_план.Профиль = '" + profil + "' ", sqlConnection);
                SqlCommand cmd4 = new SqlCommand("SELECT COUNT(*) FROM Аттестация WHERE ЗачетнаяКнижка = '" + numberSt + "' AND Профиль = '" + profil + "'", sqlConnection);
                string spSt = cmd2.ExecuteScalar().ToString();
                string spPr = cmd3.ExecuteScalar().ToString();
                int result = (int)cmd4.ExecuteScalar();

                if (result!=0) { MessageBox.Show("Оценка уже выставлена!!! ", "Внимание"); }
                else
                {
                    if (semester < kurs * 2)
                    {
                        if (spPr == spSt)
                        {
                            string query = $"INSERT INTO Аттестация ( [Профиль] , [ЗачетнаяКнижка],  [Id_преподавателя]," +
                           $"[Зачет], [Экзамен],[Курсовая],[Реферат],[Ргр],[Практика],[Рр])" +
                           $"VALUES('{profil}' , '{numberSt}',  '{IdPr}','{z}','{E}'," +
                           $"'{k}','{r}','{rgr}','{pr}','{rr}') ";
                            command(query);

                        }
                        else { MessageBox.Show("У этого студента нет такой дисциплины в плане ", "Внимание"); }


                    }
                    else { MessageBox.Show("У этого студента курс ниже ", "Внимание"); }
                }
          }
           catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
        
        public void insertData1(string Id, string Kaf, string F, string Name, string Ot, string St, string Zv)
        {
            string query = $"INSERT INTO Преподаватели ([Id_Преподавателя], [Наименование_Кафедры], [Фамилия] , [Имя]," +
                $"[Отчество], [Ученое звание],[Стаж])" +
                $"VALUES('{Id}','{Kaf}' ,'{F}', '{Name}', '{Ot}','{Zv}','{St}')";

            command(query);

        }
        string StNum;
        int StNumInt;
        public void insertData2(string Id, string F, string Name, string Ot, string K, string Gr)
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Студенты WHERE Номер_Группы = '" + Gr + "' ", sqlConnection);
                SqlCommand cmd2 = new SqlCommand("SELECT Количество_студентов FROM Группы WHERE Номер_Группы = '" + Gr + "' ", sqlConnection);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    StNum = dr["Количество_студентов"].ToString();
                }
                StNumInt = Convert.ToInt32(StNum);
                int StOb = (int)cmd1.ExecuteScalar();
                if (StOb == StNumInt)
                {
                    MessageBox.Show("Группа заполнена!");
                }
                else
                {

                    string query = $"INSERT INTO Студенты ([ЗачетнаяКнижка], [Номер_Группы], [Фамилия] , [Имя], [Отчество], [Курс]) VALUES('{Id}','{Gr}','{F}','{Name}','{Ot}','{K}')";

                    command(query);
                }
            }
            catch (Exception ex) {MessageBox.Show(ex.Message, " "); }
        }
        public void insertData3(string Kod,string Fak, string Name)
        {
            string query = $"INSERT INTO Специальность ([Код_Специальности], [Название_Специальности], [Название_Факультета])" +
                $" VALUES('{Kod}','{Fak}','{Name}')";
            command(query);
        }
        public void insertData4(string Num, string Kol, string Kod)
        {
            string query =
            $"INSERT INTO Группы ([Номер_Группы], [Количество_студентов], [Код_Специальности])" +
            $" VALUES('{Num}','{Kol}', '{Kod}')";
            command(query);
        }

        public void insertData5(string Fak)
        {
            string query = $"INSERT INTO Факультет ([Название_Факультета]) VALUES ('{Fak}')";
            command(query);
        }
        public void insertData6(string Kaf, string Fak)
        {
            string query = $"INSERT INTO Кафедра ([Наименование_Кафедры], [Название_Факультета]) VALUES ('{Kaf}', '{Fak}')";
            command(query);
        }
        public void insertData7(string Id, string Name)
        {
            
            string query = $"INSERT INTO Дисциплины ([Индекс_Дисциплины], [Название_Дисциплины]) VALUES ('{Id}', '{Name}')";
            
            command(query);
        }
       
        public void insertData8(string Prof, string Sp,string Dis, string Time, string Sem)
        {
            try
            {
                string query = $"INSERT INTO Учебный_план ([Профиль],  [Специальность], [Индекс_Дисциплины], [Семестр], [Кол_часов] ) " +
                    $"VALUES ('{Prof}', '{Sp}', '{Dis}', '{Sem}', '{Time}')";

                command(query);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

        public void command(string query)
        {
            try
            {
                SqlCommand Command = new SqlCommand(query, sqlConnection);

                if (Command.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                }
                else
                {
                    MessageBox.Show("Данные добавлены!", "Внимание!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

        

    }
}
