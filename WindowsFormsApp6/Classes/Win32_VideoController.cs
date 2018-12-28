using ORMi;

namespace WindowsFormsApp6
{
    [WMIClass("Win32_VideoController")]
    public class Win32_VideoController
    {
        public string Caption { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}