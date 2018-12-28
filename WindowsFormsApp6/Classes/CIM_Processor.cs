using System.Collections.Generic;
using ORMi;

namespace WindowsFormsApp6
{
    [WMIClass("CIM_Processor")]
    public abstract class CIM_Processor : CIM_LogicalDevice
    {
        public ushort AddressWidth { get; set; }

        //public ushort Availability { get; set; }
        //public string Caption { get; set; }
        //public uint ConfigManagerErrorCode { get; set; }
        //public bool ConfigManagerUserConfig { get; set; }
        //public string CreationClassName { get; set; }
        public uint CurrentClockSpeed { get; set; }

        public ushort DataWidth { get; set; }

        //public string Description { get; set; }
        //public string DeviceID { get; set; }
        //public bool ErrorCleared { get; set; }
        //public string ErrorDescription { get; set; }
        public ushort Family { get; set; }

        //public DateTime InstallDate { get; set; }
        //public uint LastErrorCode { get; set; }
        public ushort LoadPercentage { get; set; }

        public uint MaxClockSpeed { get; set; }

        //public string Name { get; set; }
        public string OtherFamilyDescription { get; set; }

        //public string PNPDeviceID { get; set; }
        //public ushort[] PowerManagementCapabilities { get; set; }
        //public bool PowerManagementSupported { get; set; }
        public string Role { get; set; }

        //public string Status { get; set; }
        //public ushort StatusInfo { get; set; }
        public string Stepping { get; set; }

        //public string SystemCreationClassName { get; set; }
        //public string SystemName { get; set; }
        public string UniqueId { get; set; }
        public ushort UpgradeMethod { get; set; }

        private static readonly Dictionary<ushort, string> FamilyRef = new Dictionary<ushort, string>
        {
            {1, "Other"},
            {2, "Unknown"},
            {3, "8086"},
            {4, "80286"},
            {5, "Intel386™ Processor"},
            {6, "Intel486™ Processor"},
            {7, "8087"},
            {8, "80287"},
            {9, "80387"},
            {10, "80487"},
            {11, "Pentium Brand"},
            {12, "Pentium Pro"},
            {13, "Pentium II"},
            {14, "Pentium Processor with MMX™ Technology"},
            {15, "Celeron™"},
            {16, "Pentium II Xeon™"},
            {17, "Pentium III"},
            {18, "M1 Family"},
            {19, "M2 Family"},
            {24, "AMD Duron™ Processor Family"},
            {25, "K5 Family"},
            {26, "K6 Family"},
            {27, "K6-2"},
            {28, "K6-3"},
            {29, "AMD Athlon™ Processor Family"},
            {30, "AMD2900 Family"},
            {31, "K6-2+"},
            {32, "Power PC Family"},
            {33, "Power PC 601"},
            {34, "Power PC 603"},
            {35, "Power PC 603+"},
            {36, "Power PC 604"},
            {37, "Power PC 620"},
            {38, "Power PC X704"},
            {39, "Power PC 750"},
            {48, "Alpha Family"},
            {49, "Alpha 21064"},
            {50, "Alpha 21066"},
            {51, "Alpha 21164"},
            {52, "Alpha 21164PC"},
            {53, "Alpha 21164a"},
            {54, "Alpha 21264"},
            {55, "Alpha 21364"},
            {64, "MIPS Family"},
            {65, "MIPS R4000"},
            {66, "MIPS R4200"},
            {67, "MIPS R4400"},
            {68, "MIPS R4600"},
            {69, "MIPS R10000"},
            {80, "SPARC Family"},
            {81, "SuperSPARC"},
            {82, "microSPARC II"},
            {83, "microSPARC IIep"},
            {84, "UltraSPARC"},
            {85, "UltraSPARC II"},
            {86, "UltraSPARC IIi"},
            {87, "UltraSPARC III"},
            {88, "UltraSPARC IIIi"},
            {96, "68040"},
            {97, "68xxx Family"},
            {98, "68000"},
            {99, "68010"},
            {100, "68020"},
            {101, "68030"},
            {112, "Hobbit Family"},
            {120, "Crusoe™ TM5000 Family"},
            {121, "Crusoe™ TM3000 Family"},
            {122, "Efficeon™ TM8000 Family"},
            {128, "Weitek"},
            {130, "Itanium™ Processor"},
            {131, "AMD Athlon™ 64 Processor Famiily"},
            {132, "AMD Opteron™ Processor Family"},
            {144, "PA-RISC Family"},
            {145, "PA-RISC 8500"},
            {146, "PA-RISC 8000"},
            {147, "PA-RISC 7300LC"},
            {148, "PA-RISC 7200"},
            {149, "PA-RISC 7100LC"},
            {150, "PA-RISC 7100"},
            {160, "V30 Family"},
            {176, "Pentium III Xeon™ Processor"},
            {177, "Pentium III Processor with Intel SpeedStep™ Technology"},
            {178, "Pentium 4"},
            {179, "Intel Xeon™"},
            {180, "AS400 Family"},
            {181, "Intel Xeon™ Processor MP"},
            {182, "AMD Athlon™ XP Family"},
            {183, "AMD Athlon™ MP Family"},
            {184, "Intel Itanium 2"},
            {185, "Intel Pentium M Processor"},
            {190, "K7"},
            {200, "IBM390 Family"},
            {201, "G4"},
            {202, "G5"},
            {203, "G6"},
            {204, "z/Architecture Base"},
            {250, "i860"},
            {251, "i960"},
            {260, "SH-3"},
            {261, "SH-4"},
            {280, "ARM"},
            {281, "StrongARM"},
            {300, "6x86"},
            {301, "MediaGX"},
            {302, "MII"},
            {320, "WinChip"},
            {350, "DSP"},
            {500, "Video Processor"}
        };

        public static string ConvertFamily(ushort familyCode)
        {
            try
            {
                return FamilyRef[familyCode];
            }
            catch
            {
                return "N/A";
            }
        }
    }


}