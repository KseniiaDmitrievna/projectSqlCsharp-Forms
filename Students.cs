
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace kursah
{
    public partial class Students : System.Windows.Forms.Form
    {
        public Students()
        {
            InitializeComponent();
        }
        Show show = new Show();

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string st = NumTb.Text.ToString();
                if (show.proverka(st) == true)
                {
                    System.Data.DataTable dt = show.poisk(st);
                    dataGridView1.DataSource = dt;
                    
                   dataGridView1.Columns[0].HeaderCell.Value = "Дисциплина";
                    dataGridView1.Columns[1].HeaderCell.Value = "Фамилия преподавателя";
                    System.Data.DataTable dtName = show.poiskName(st);
                    NameLb.Text = dtName.Rows[0]["Фамилия"].ToString() + " " + dtName.Rows[0]["Имя"].ToString() + " " + dtName.Rows[0]["Отчество"].ToString();

                }
                else { MessageBox.Show("В базе нет такого номера зачетной книжки!", "Внимание!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

        private void btnExport_Click(object sender, EventArgs e)
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
    }
}
