using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DieselElcatKgUpper.Data
{
    public class UpRecordManager
    {
        private static UpRecordManager _instance = null;

        public List<UpRecord> UpRecords { get; set; }

        public static UpRecordManager GetInstance()
        {
            if (_instance == null)
                _instance = new UpRecordManager();
            return _instance;
        }

        private UpRecordManager()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<UpRecord>));
            if (File.Exists("records.xml"))
            {
                using (Stream stream = new FileStream("records.xml", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    UpRecords = (List<UpRecord>)serializer.Deserialize(stream);
                }
            }
            else
            {
                UpRecords = new List<UpRecord>();
            }
        }

        public void  Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<UpRecord>));
            if (File.Exists("records.xml"))
                File.Delete("records.xml");
            using (Stream stream = new FileStream("records.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.Serialize(stream, UpRecords);
            }
        }

        public void Update(DataGridView grid)
        {
            grid.DataSource = null;
            grid.DataSource = UpRecords;
        }
    }
}
