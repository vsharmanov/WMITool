using System;
using ORMi;

namespace WindowsFormsApp6
{
    [WMIClass("CIM_ManagedSystemElement")]
    public abstract class CIM_ManagedSystemElement
    {
        public string Caption { get; set; }
        public string Description { get; set; }
        public DateTime InstallDate { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}