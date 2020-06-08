using DieselElcatKgUpper.Classes;
using DieselElcatKgUpper.Data;
using FontAwesome.Sharp;
using System;
using System.Windows.Forms;

namespace DieselElcatKgUpper.Forms
{
    public partial class frmRecords : Form
    {
        public frmRecords()
        {
            InitializeComponent();
            UpRecordManager.GetInstance().Update(dataGridView);
            UpWorker.GetInstance().ListChanged += FrmMain_ListChanged;
            ChangeBtnIcon();
        }

        private void FrmMain_ListChanged()
        {
            try
            {
                Invoke((MethodInvoker)delegate { UpRecordManager.GetInstance().Update(dataGridView); });
            }
            catch
            {

            }
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            UpWorker.GetInstance().isPause = !UpWorker.GetInstance().isPause;
            ChangeBtnIcon();
        }

        private void ChangeBtnIcon()
        {
            if (UpWorker.GetInstance().isPause)
            {
                btnStartPause.IconChar = IconChar.Play;
                btnStartPause.Text = "Start";
            }
            else
            {
                btnStartPause.IconChar = IconChar.Pause;
                btnStartPause.Text = "Pause";
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
