using DieselElcatKgUpper.Forms;
using System.Windows.Forms;

namespace DieselElcatKgUpper
{
    public partial class frmMain : Form
    {

        private Form CurrentForm = null;

        public frmMain()
        {
            InitializeComponent();
            ShowChild(new frmRecords());
        }

        private void ShowChild(Form form)
        {
            if (CurrentForm != null)
                CurrentForm.Close();
            CurrentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            pnlContent.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnRecords_Click(object sender, System.EventArgs e)
        {
            ShowChild(new frmRecords());
        }

        private void btnAddTheme_Click(object sender, System.EventArgs e)
        {
            ShowChild(new frmAddRecord());
        }

        private void btnAddAccount_Click(object sender, System.EventArgs e)
        {
            ShowChild(new frmAddAccount());
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            ShowChild(new frmSettings());
        }
    }
}
