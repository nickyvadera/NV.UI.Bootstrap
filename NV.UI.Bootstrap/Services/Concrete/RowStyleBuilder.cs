using NV.UI.Bootstrap.Classes;
using NV.UI.Bootstrap.Models;
using NV.UI.Bootstrap.Services.Abstract;
using System;

namespace NV.UI.Bootstrap.Services.Concrete
{
    public class RowStyleBuilder : StyleBuilder, IRowStyleBuilder
    {
        public IRowStyleBuilder WithGutter(Enums.Spacing spacing, Enums.Axis? axis = null, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(GutterAction(spacing, new GutterConfiguration(axis, breakpoint)));
            return this;
        }

        public IRowStyleBuilder WithRowColumns(Enums.RowColumns rowColumns, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(RowColumnsAction(rowColumns, breakpoint));
            return this;
        }

        private static Action<Style> GutterAction(Enums.Spacing spacing, GutterConfiguration configuration)
        {
            return style => style.Gutters[configuration] = spacing;
        }

        private static Action<Style> RowColumnsAction(Enums.RowColumns rowColumns, Enums.Breakpoint breakpoint)
        {
            return style => style.RowColumns[breakpoint] = rowColumns;
        }
    }
}
