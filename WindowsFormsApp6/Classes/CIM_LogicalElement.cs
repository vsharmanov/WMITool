using ORMi;

namespace WindowsFormsApp6
{
    [WMIClass("CIM_LogicalElement")]
    public abstract class CIM_LogicalElement : CIM_ManagedSystemElement
    {
        //public string Caption { get; set; }
        //public string Description { get; set; }
        //public DateTime InstallDate { get; set; }
        //public string Name { get; set; }
        //public string Status { get; set; }
    }

    [WMIClass("CopyOfCIM_LogicalElement")]
    public abstract class CopyOfCIM_LogicalElement : CIM_ManagedSystemElement
    {
        //public string Caption { get; set; }
        //public string Description { get; set; }
        //public DateTime InstallDate { get; set; }
        //public string Name { get; set; }
        //public string Status { get; set; }
    }
}