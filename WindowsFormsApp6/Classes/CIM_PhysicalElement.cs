﻿using ORMi;

namespace WindowsFormsApp6
{
    [WMIClass("CIM_PhysicalElement")]
    public abstract class CIM_PhysicalElement: CIM_ManagedSystemElement
    {
        //public string Caption { get; set; }
        //public string Description { get; set; }
        //public DateTime InstallDate { get; set; }
        //public string Name { get; set; }
        //public string Status { get; set; }
        public string CreationClassName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string OtherIdentifyingInfo { get; set; }
        public string PartNumber { get; set; }
        public bool PoweredOn { get; set; }
        public string SerialNumber { get; set; }
        public string SKU { get; set; }
        public string Tag { get; set; }
        public string Version { get; set; }
    }
}