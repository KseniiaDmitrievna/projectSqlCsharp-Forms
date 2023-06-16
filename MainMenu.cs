using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursah
{
    public partial class MainMenu : System.Windows.Forms.Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdministrator formAdministrator = new FormAdministrator();
            formAdministrator.Show();
        }
       
        private void btnStudent_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
        }
    }
}
