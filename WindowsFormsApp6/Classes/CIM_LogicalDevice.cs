using System;
using ORMi;

namespace WindowsFormsApp6
{
    [WMIClass("CIM_LogicalDevice")]
    public abstract class CIM_LogicalDevice : CIM_LogicalElement
    {
        //public string Caption { get; set; }
        //public string Description { get; set; }
        //public DateTime InstallDate { get; set; }
        //public string Name { get; set; }
        //public string Status { get; set; }
        public ushort Availability { get; set; }
        public uint ConfigManagerErrorCode { get; set; }
        public bool ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public string DeviceID { get; set; }
        public ushort[] PowerManagementCapabilities { get; set; }
        public bool ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public uint LastErrorCode { get; set; }
        public string PNPDeviceID { get; set; }
        public bool PowerManagementSupported { get; set; }
        public ushort StatusInfo { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }

        public uint Reset()
        {
            return WMIMethod.ExecuteMethod(this);
        }

        public uint SetPowerState(ushort powerState, DateTime date)
        {
            return WMIMethod.ExecuteMethod(this, new {PowerState = powerState, Date = date});
        }
    }

 }