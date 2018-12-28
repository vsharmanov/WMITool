using ORMi;

namespace WindowsFormsApp6
{
    [WMIClass("Win32_Volume")]
    public class Win32_Volume
    {
        public string Caption { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}