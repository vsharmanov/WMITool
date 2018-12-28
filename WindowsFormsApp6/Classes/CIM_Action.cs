using System;
using System.Collections.Generic;
using ORMi;

namespace WindowsFormsApp6
{
    [WMIClass("CIM_Action")]
    public abstract class CIM_Action
    {
        public string ActionID { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public ushort Direction { get; set; }
        public string Name { get; set; }
        public string SoftwareElementId { get; set; }
        public ushort SoftwareElementState { get; set; }
        public ushort TargetOperatingSystem { get; set; }
        public string Version { get; set; }

        
    }
}