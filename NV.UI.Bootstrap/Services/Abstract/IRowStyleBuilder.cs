using NV.UI.Bootstrap.Classes;

namespace NV.UI.Bootstrap.Services.Abstract
{
    public interface IRowStyleBuilder : IStyleBuilder
    {
        IRowStyleBuilder WithGutter(Enums.Spacing spacing, Enums.Axis? axis = null, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IRowStyleBuilder WithRowColumns(Enums.RowColumns rowColumns, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);
    }
}
