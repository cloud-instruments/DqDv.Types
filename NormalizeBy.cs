using System.ComponentModel;

namespace Dqdv.Types
{
    public enum NormalizeBy
    {
        [Description("")]
        None = 0,
        [Description("g")]
        Mass = 1,
        [Description("sq.sm.")]
        Area = 2,
        [Description("Area-specific Impedance")]
        Asi = 3 //area-specific impedance
    }
}
