using NV.UI.Bootstrap.Classes;
using NV.UI.Bootstrap.Models;
using NV.UI.Bootstrap.Services.Abstract;
using System;

namespace NV.UI.Bootstrap.Services.Concrete
{
    public class ColumnStyleBuilder : StyleBuilder, IColumnStyleBuilder
    {
        public IColumnStyleBuilder WithColumn(Enums.Columns? columns = null, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(ColumnAction(columns, breakpoint));
            return this;
        }

        public IColumnStyleBuilder WithOffset(Enums.Columns columns, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(OffsetAction(columns, breakpoint));
            return this;
        }

        private static Action<Style> ColumnAction(Enums.Columns? columns, Enums.Breakpoint breakpoint)
        {
            return style => style.Columns[breakpoint] = columns;
        }

        private static Action<Style> OffsetAction(Enums.Columns columns, Enums.Breakpoint breakpoint)
        {
            return style => style.Offsets[breakpoint] = columns;
        }
    }
}
