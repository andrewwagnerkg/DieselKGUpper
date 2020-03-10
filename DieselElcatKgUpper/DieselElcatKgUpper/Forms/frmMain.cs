using DieselElcatKgUpper.Data;
using DieselElcatKgUpper.Forms;
using System.Windows.Forms;

namespace DieselElcatKgUpper
{
    public partial class frmMain : Form
    {

        private bool isShown=true;
        private bool forseclose = false;
        private Form CurrentForm = null;

        public frmMain()
        {
            InitializeComponent();
            ShowChild(new frmRecords());
            this.Text += $" - [{AccountManager.GetInstance().Account.Login}]";
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

        private void показатьСкрытьToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (isShown) Hide();
            else { Show(); this.WindowState = FormWindowState.Normal; }
            isShown = !isShown;
        }

        private void выходToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            forseclose = true;
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !forseclose;
            if(!forseclose)
            {
                Hide();
                isShown = !isShown;
            }
        }

        private void frmMain_Resize(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            { this.isShown = !isShown; Hide(); }

        }
    }
}
