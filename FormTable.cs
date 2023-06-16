using System;
using System.Windows.Forms;

namespace kursah
{
    public partial class FormTable : System.Windows.Forms.Form
    {
        public FormTable()
        {
            InitializeComponent();
        }
        Show show = new Show();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = show.tableDisplay(comboBox1.Text);

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                show.saveDate(comboBox1.Text);
            }
            catch (InvalidCastException ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                show.saveDate(comboBox1.Text);
            }
            catch (InvalidCastException ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
    }
}
