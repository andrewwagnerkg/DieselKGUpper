using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DieselElcatKgUpper.Data
{
    public class AccountManager
    {

        private static AccountManager _instance = null;
        public static AccountManager GetInstance()
        {
            if (_instance == null)
                _instance = new AccountManager();
            return _instance;
        }
        public Account Account { get; set; }

        private AccountManager()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Account));
            if (File.Exists("account.xml"))
            {
                using (Stream stream = new FileStream("account.xml", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    Account =(Account)serializer.Deserialize(stream);
                }
            }
            else
            {
                Account = new Account();
            }
                
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Account));
            if (File.Exists("account.xml"))
                File.Delete("account.xml");
            using(Stream stream=new FileStream("account.xml",FileMode.OpenOrCreate,FileAccess.Write))
            {
                serializer.Serialize(stream, Account);
            }
            
        }
    }
}
