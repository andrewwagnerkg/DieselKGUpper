using DieselElcatKgUpper.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieselElcatKgUpper.Forms
{
    public partial class frmSettings : Form
    {
        Account currentaccount;
        public frmSettings()
        {
            InitializeComponent();
            currentaccount = AccountManager.GetInstance().Account;
            txtLogin.Text = currentaccount.Login;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentaccount.Login = txtLogin.Text;
            currentaccount.Password = txtPassword.Text;
            AccountManager.GetInstance().Account = currentaccount;
            AccountManager.GetInstance().Save();
        }
    }
}
