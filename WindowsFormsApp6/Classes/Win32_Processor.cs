using System.Collections.Generic;
using ORMi;

namespace WindowsFormsApp6
{
    [WMIClass("Win32_Processor")]
    public class Win32_Processor : CIM_Processor
    {
        //public ushort AddressWidth { get; set; }
        public ushort Architecture { get; set; }

        public string AssetTag { get; set; }

        //public ushort Availability { get; set; }
        //public string Caption { get; set; }
        public uint Characteristics { get; set; }

        //public uint ConfigManagerErrorCode { get; set; }
        //public bool ConfigManagerUserConfig { get; set; }
        public ushort CpuStatus { get; set; }

        //public string CreationClassName { get; set; }
        //public uint CurrentClockSpeed { get; set; }
        public ushort CurrentVoltage { get; set; }

        //public ushort DataWidth { get; set; }
        //public string Description { get; set; }
        //public string DeviceID { get; set; }
        //public bool ErrorCleared { get; set; }
        //public string ErrorDescription { get; set; }
        public uint ExtClock { get; set; }

        //public ushort Family { get; set; }
        //public DateTime InstallDate { get; set; }
        public uint L2CacheSize { get; set; }
        public uint L2CacheSpeed { get; set; }
        public uint L3CacheSize { get; set; }

        public uint L3CacheSpeed { get; set; }

        //public uint LastErrorCode { get; set; }
        public ushort Level { get; set; }

        //public ushort LoadPercentage { get; set; }
        public string Manufacturer { get; set; }

        //public uint MaxClockSpeed { get; set; }
        //public string Name { get; set; }
        public uint NumberOfCores { get; set; }
        public uint NumberOfEnabledCore { get; set; }

        public uint NumberOfLogicalProcessors { get; set; }

        //public string OtherFamilyDescription { get; set; }
        public string PartNumber { get; set; }

        //public string PNPDeviceID { get; set; }
        //public ushort[] PowerManagementCapabilities { get; set; }
        //public bool PowerManagementSupported { get; set; }
        public string ProcessorId { get; set; }
        public ushort ProcessorType { get; set; }

        public ushort Revision { get; set; }

        //public string Role { get; set; }
        public bool SecondLevelAddressTranslationExtensions { get; set; }
        public string SerialNumber { get; set; }

        public string SocketDesignation { get; set; }

        //public string Status { get; set; }
        //public ushort StatusInfo { get; set; }
        //public string Stepping { get; set; }
        //public string SystemCreationClassName { get; set; }
        //public string SystemName { get; set; }
        public uint ThreadCount { get; set; }

        //public string UniqueId { get; set; }
        //public ushort UpgradeMethod { get; set; }
        public string Version { get; set; }

        public bool VirtualizationFirmwareEnabled { get; set; }

        //public bool VMMonitorModeExtensions { get; set; }
        public uint VoltageCaps { get; set; }

        private static readonly Dictionary<int, string> ArchitectureRef = new Dictionary<int, string>
        {
            {0, "x86"},
            {1, "MIPS"},
            {2, "Alpha"},
            {3, "PowerPC"},
            {6, "Itanium-based System"},
            {9, "x64"}
        };

        private static readonly Dictionary<ushort, string> AvailabilityRef = new Dictionary<ushort, string>
        {
            {1, "Other"},
            {2, "Unknown"},
            {3, "Running on Full Power"},
            {4, "Warning"},
            {5, "In Test"},
            {6, "Not Applicable"},
            {7, "Power Off"},
            {8, "Off Line"},
            {9, "Off Duty"},
            {10, "Degraded"},
            {11, "Not Installed"},
            {12, "Install Error"},
            {13, "Power Save - Unknown"},
            {14, "Power Save - Low Power Mode"},
            {15, "Power Save - Standby"},
            {16, "Power Cycle"},
            {17, "Power Save - Warning"},
            {18, "Paused"},
            {19, "Not Ready"},
            {20, "Not Configured"},
            {21, "Quiesced"}
        };

        private static readonly Dictionary<ushort, string> CpuStatusRef = new Dictionary<ushort, string>
        {
            {0, "Unknown"},
            {1, "CPU Enabled"},
            {2, "CPU Disabled by User via BIOS Setup"},
            {3, "CPU Disabled By BIOS (POST Error)"},
            {4, "CPU is Idle"},
            {5, "Reserved"},
            {6, "Reserved"},
            {7, "Other"}
        };

        

        private static readonly Dictionary<ushort, string> ProcessorTypeRef = new Dictionary<ushort, string>
        {
            {1, "Other"},
            {2, "Unknown "},
            {3, "Central Processor"},
            {4, "Math Processor"},
            {5, "DSP Processor"},
            {6, "Video Processor"}
        };

        public static string ConvertArchitecture(ushort architectureCode)
        {
            try
            {
                return ArchitectureRef[architectureCode];
            }
            catch
            {
                return "N/A";
            }
        }

        public static string ConvertAvailability(ushort availabilityCode)
        {
            try
            {
                return AvailabilityRef[availabilityCode];
            }
            catch
            {
                return "N/A";
            }
        }

        public static string ConvertCpuStatus(ushort cpuStatusCode)
        {
            try
            {
                return CpuStatusRef[cpuStatusCode];
            }
            catch
            {
                return "N/A";
            }
        }

        public static string ConvertProcessorType(ushort processorTypeCode)
        {
            try
            {
                return ProcessorTypeRef[processorTypeCode];
            }
            catch
            {
                return "N/A";
            }
        }
    }
}