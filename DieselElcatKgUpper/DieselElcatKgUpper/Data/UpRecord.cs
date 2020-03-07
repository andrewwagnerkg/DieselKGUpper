using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieselElcatKgUpper.Data
{
    public class UpRecord
    {
        public int ThemeId { get; set; }
        public DateTime LastUpdate { get; set; }
        public Account Account { get; set; }
        public string Result { get; set; }
    }
}
