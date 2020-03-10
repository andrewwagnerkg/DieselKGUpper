using DieselElcatKgUpper.Data;
using System;
using System.Windows.Forms;

namespace DieselElcatKgUpper.Forms
{
    public partial class frmAddRecord : Form
    {
        public event Action<UpRecord> RecordListChanged;
        UpRecord currentRecord;

        public frmAddRecord()
        {
            InitializeComponent();
            dataGridView.DataSource = UpRecordManager.GetInstance().UpRecords;
            dataGridView.RowEnter += dataGridView_RowEnters;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrl.Text) || string.IsNullOrEmpty(txtUrl.Text)) return;
            currentRecord = new UpRecord
            {
                LastUpdate = DateTime.Now,
                Result = string.Empty,
                ThemeUrl = txtUrl.Text
            };
            txtUrl.Text = string.Empty;
            if (UpRecordManager.GetInstance().UpRecords.FindAll(u => u.ThemeUrl == currentRecord.ThemeUrl).Count != 0) return;
            UpRecordManager.GetInstance().UpRecords.Add(currentRecord);
            UpRecordManager.GetInstance().Save();
            UpRecordManager.GetInstance().Update(dataGridView);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void frmAddRecord_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView_RowEnters(object sender, DataGridViewCellEventArgs e)
        {
            currentRecord = new UpRecord()
            {
                ThemeUrl = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),
                LastUpdate = DateTime.Parse(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()),
                Result = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()
            };
        }

        private void btnRemoove_Click(object sender, EventArgs e)
        {
            if (currentRecord == null) return;
            UpRecordManager.GetInstance().UpRecords.Remove(UpRecordManager.GetInstance().UpRecords.Find(p=>p.ThemeUrl==currentRecord.ThemeUrl));
            UpRecordManager.GetInstance().Save();
            UpRecordManager.GetInstance().Update(dataGridView);
        }
    }
}
