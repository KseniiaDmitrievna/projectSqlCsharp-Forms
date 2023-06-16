using System;
using System.Windows.Forms;

namespace kursah
{
    public partial class FormAdministrator : System.Windows.Forms.Form
    {
        public FormAdministrator()
        {
            InitializeComponent();
        }

        FormAttestation formAttestation = new FormAttestation();
        FormTeacher formTeacher = new FormTeacher();
        FormStudents formStudents = new FormStudents();
        FormSpeciality formSpeciality = new FormSpeciality();
        FormTable formTable = new FormTable();
        Form formOtchet = new Form();
        FormUspevaemost formUspevaemost = new FormUspevaemost();
       
        private void btnAttest_Click(object sender, EventArgs e)
        {
            try
            {
                if (formAttestation == null || formAttestation.IsDisposed)
                {
                    formAttestation = new FormAttestation();
                    formAttestation.Show();
                }
                else { formAttestation.Show(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
            formAttestation.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (formTeacher == null || formTeacher.IsDisposed)
                {
                    formTeacher = new FormTeacher();
                    formTeacher.Show();
                }
                else { formTeacher.Show(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
        private void btnStudents_Click(object sender, EventArgs e)
        {
            try
            {
                if (formStudents == null || formStudents.IsDisposed)
                {
                    formStudents = new FormStudents();
                    formStudents.Show();
                }
                else { formStudents.Show(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

        private void btnUniverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (formSpeciality == null || formSpeciality.IsDisposed)
                {
                  formSpeciality = new FormSpeciality();
                    formSpeciality.Show();
                }
                else { formSpeciality.Show(); ; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
          
        }
        private void btnTables_Click(object sender, EventArgs e)
        {
            try
            {
                if (formTable == null || formTable.IsDisposed)
                {
                    formTable = new FormTable();
                    formTable.Show();
                }
                else { formTable.Show(); ; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
        private void btnOtchet_Click(object sender, EventArgs e)
        {
            try
            {
                if (formOtchet == null || formOtchet.IsDisposed)
                {
                    formOtchet = new Form();
                    formOtchet.Show();
                }
                else { formOtchet.Show();  }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }

        private void buttonOtchet_Click(object sender, EventArgs e)
        {
            try
            {
                if (formUspevaemost == null || formUspevaemost.IsDisposed)
                {
                    formUspevaemost = new FormUspevaemost();
                    formUspevaemost.Show();
                }
                else { formUspevaemost.Show(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!"); }
        }
    }
}
