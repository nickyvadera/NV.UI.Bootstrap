using NV.UI.Bootstrap.Classes;

namespace NV.UI.Bootstrap.Services.Abstract
{
    public interface IColumnStyleBuilder : IStyleBuilder
    {
        IColumnStyleBuilder WithColumn(Enums.Columns? columns = null, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IColumnStyleBuilder WithOffset(Enums.Columns columns, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);
    }
}
