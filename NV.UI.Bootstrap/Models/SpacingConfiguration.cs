using NV.UI.Bootstrap.Classes;

namespace NV.UI.Bootstrap.Models
{
    public struct SpacingConfiguration
    {
        internal Enums.Breakpoint Breakpoint { get; set; }
        internal Enums.Side? Side { get; set; }

        public SpacingConfiguration(Enums.Breakpoint breakpoint, Enums.Side? side)
        {
            Breakpoint = breakpoint;
            Side = side;
        }
    }
}
