using System;
using ORMi;

namespace WindowsFormsApp6
{
    [WMIClass("CIM_ActionSequence")]
    public abstract class CIM_ActionSequence
    {
        public CIM_Action Next { get; set; }
        public CIM_Action Prior { get; set; }

    }
}