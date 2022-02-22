using NV.UI.Bootstrap.Classes;

namespace NV.UI.Bootstrap.Models
{
    public struct GutterConfiguration
    {
        public Enums.Axis? Axis { get; set; }
        public Enums.Breakpoint Breakpoint { get; set; }

        public GutterConfiguration(Enums.Axis? axis, Enums.Breakpoint breakpoint)
        {
            Axis = axis;
            Breakpoint = breakpoint;
        }
    }
}
