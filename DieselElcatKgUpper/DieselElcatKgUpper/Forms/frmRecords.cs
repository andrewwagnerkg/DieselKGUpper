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
    public partial class frmRecords : Form
    {
        public frmRecords()
        {
            InitializeComponent();
            UpRecordManager.GetInstance().Update(dataGridView);
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {

        }
    }
}
