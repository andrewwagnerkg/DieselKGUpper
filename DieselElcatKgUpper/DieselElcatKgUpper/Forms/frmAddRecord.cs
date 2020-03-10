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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentRecord = new UpRecord {
                LastUpdate = DateTime.Now,
                Result = string.Empty,
                ThemeUrl = txtUrl.Text
            };
            UpRecordManager.GetInstance().UpRecords.Add(currentRecord);
            UpRecordManager.GetInstance().Save();
            UpRecordManager.GetInstance().Update(dataGridView);
            
        }
    }
}
