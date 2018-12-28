using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMi;


namespace WmiHelper
{
    public class Win32_Processor
    {
        public string Name { get; set; }

        [WMIProperty("NumberOfCores")]
        public int Cores { get; set; }

        public string Description { get; set; }
    }
}
