using Microsoft.Extensions.Options;
using NV.UI.Bootstrap.Classes;
using NV.UI.Bootstrap.Models;
using NV.UI.Bootstrap.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NV.UI.Bootstrap.Services.Concrete
{
    public class StyleRenderer : IStyleRenderer
    {
        private readonly IOptionsMonitor<BootstrapSettingsOptions> boostrapOptionsMonitor;
        private readonly ICssClassBuilder cssClassBuilder;

        public StyleRenderer(IOptionsMonitor<BootstrapSettingsOptions> boostrapOptionsMonitor, ICssClassBuilder cssClassBuilder)
        {
            this.boostrapOptionsMonitor = boostrapOptionsMonitor;
            this.cssClassBuilder = cssClassBuilder;
        }

        public IEnumerable<string> AsCssClasses(IEnumerable<IStyleBuilder> styleBuilders, string componentName = null)
        {
            var style = GetComponentStyle(componentName);
            foreach(var styleBuilder in styleBuilders)
                style = styleBuilder.Build(style);
            return AsCssClasses(style);
        }

        public IEnumerable<string> AsCssClasses(Style style)
        {
            if (style != null)
                BuildStyle(style);

            return cssClassBuilder.Build();
        }

        private Style GetComponentStyle(string componentName)
        {
            return boostrapOptionsMonitor.CurrentValue.ComponentStyles.SingleOrDefault(x => string.Equals(x.Key, componentName, StringComparison.OrdinalIgnoreCase)).Value?.Clone();
        }

        private void BuildStyle(Style style)
        {
            cssClassBuilder.AddConditionalClass(style.Active, "active");
            cssClassBuilder.AddEnumClass(style.BackgroundColour, "bg");
            cssClassBuilder.AddConditionalClass(style.BackgroundGradient, "bg-gradient");
            cssClassBuilder.AddEnumClass(style.BorderColour, "border");
            cssClassBuilder.AddEnumClass(style.BorderWidth, "border");
            cssClassBuilder.AddClasses(BuildDictionary(style.Columns, "col"));
            cssClassBuilder.AddClasses(BuildDictionary(style.Display, "d"));
            cssClassBuilder.AddClasses(BuildDictionary(style.FlexAlignContent, "align-content"));
            cssClassBuilder.AddClasses(BuildDictionary(style.FlexAlignItems, "align-items"));
            cssClassBuilder.AddClasses(BuildDictionary(style.FlexAlignSelf, "align-self"));
            cssClassBuilder.AddClasses(BuildDictionary(style.FlexDirection, "flex"));
            cssClassBuilder.AddClasses(BuildEnumerable(style.FlexFill, BuildFlexFill));
            cssClassBuilder.AddClasses(BuildDictionary(style.FlexGrow, BuildFlexGrow));
            cssClassBuilder.AddClasses(BuildDictionary(style.FlexJustifyContent, "justify-content"));
            cssClassBuilder.AddClasses(BuildDictionary(style.FlexShrink, BuildFlexShrink));
            cssClassBuilder.AddClasses(BuildDictionary(style.FlexWrap, "flex-wrap"));
            cssClassBuilder.AddClass(BuildFontItalic(style.FontItalic));
            cssClassBuilder.AddEnumClass(style.FontSize, "fs");
            cssClassBuilder.AddEnumClass(style.FontWeight, "fw");
            cssClassBuilder.AddClasses(BuildDictionary(style.Gap, "gap"));
            cssClassBuilder.AddClasses(BuildDictionary(style.Gutters, BuildGutter));
            cssClassBuilder.AddClass(BuildHeight(style.Height));
            cssClassBuilder.AddClasses(BuildDictionary(style.Margins, BuildMargin));
            cssClassBuilder.AddConditionalClass(style.MaxHeight, "mh-100");
            cssClassBuilder.AddConditionalClass(style.MaxWidth, "mw-100");
            cssClassBuilder.AddConditionalClass(style.MinViewportHeight, "min-vh-100");
            cssClassBuilder.AddConditionalClass(style.MinViewportWidth, "min-vw-100");
            cssClassBuilder.AddClasses(BuildDictionary(style.Offsets, "offset"));
            cssClassBuilder.AddEnumClass(style.Opacity, "opacity");
            cssClassBuilder.AddClasses(BuildDictionary(style.Order, "order"));
            cssClassBuilder.AddClass(BuildPointerEvents(style.PointerEvents));
            cssClassBuilder.AddEnumClass(style.Rounded, "rounded");
            cssClassBuilder.AddClasses(BuildDictionary(style.RowColumns, "row-cols"));
            cssClassBuilder.AddEnumClass(style.Shadow, "shadow");
            cssClassBuilder.AddClasses(BuildDictionary(style.TextAlignment, "text"));
            cssClassBuilder.AddEnumClass(style.TextColour, "text");
            cssClassBuilder.AddClass(BuildWidth(style.Width));
        }

        private IEnumerable<string> BuildDictionary<TKey, TValue>(IDictionary<TKey, TValue> dictionary, Func<TKey, TValue, string> buildFunction)
        {
            return dictionary.Select(i => buildFunction(i.Key, i.Value));
        }

        private IEnumerable<string> BuildDictionary<T>(IDictionary<Enums.Breakpoint, T> dictionary, string cssClassPrefix) where T : Enum
        {
            return dictionary.Select(i => BuildGeneric(cssClassPrefix, i.Key, i.Value));
        }

        private IEnumerable<string> BuildDictionary<T>(IDictionary<Enums.Breakpoint, T?> dictionary, string cssClassPrefix) where T : struct, Enum
        {
            return dictionary.Select(i => BuildGeneric(cssClassPrefix, i.Key, i.Value));
        }

        private IEnumerable<string> BuildEnumerable<T>(IEnumerable<T> items, Func<T, string> buildFunction)
        {
            return items.Select(buildFunction);
        }

        private string BuildGeneric(string prefix, Enums.Breakpoint breakpoint, Enum value)
        {
            return cssClassBuilder.BuildClass(prefix, breakpoint.GetDescription(), value.GetDescription());
        }

        private string BuildFlexFill(Enums.Breakpoint breakpoint)
        {
            return cssClassBuilder.BuildClass("flex", breakpoint.GetDescription(), "fill");
        }

        private string BuildFlexGrow(Enums.Breakpoint breakpoint, bool grow)
        {
            return cssClassBuilder.BuildClass("flex", breakpoint.GetDescription(), "grow", grow ? "1" : "0");
        }

        private string BuildFlexShrink(Enums.Breakpoint breakpoint, bool shrink)
        {
            return cssClassBuilder.BuildClass("flex", breakpoint.GetDescription(), "shrink", shrink ? "1" : "0");
        }

        private string BuildFontItalic(bool? italic)
        {
            if (!italic.HasValue)
                return null;
            return cssClassBuilder.BuildClass($"fst", italic.Value ? "italic" : "normal");
        }

        private string BuildGutter(GutterConfiguration gutterConfiguration, Enums.Spacing spacing)
        {
            return cssClassBuilder.BuildClass($"g{gutterConfiguration.Axis.GetDescription()}", gutterConfiguration.Breakpoint.GetDescription(), spacing.GetDescription());
        }

        private string BuildHeight(Enums.DimentionSize? dimentionSize)
        {
            if (!dimentionSize.HasValue)
                return null;
            return dimentionSize == Enums.DimentionSize.Viewport ? "vh-100" : cssClassBuilder.BuildClass("h", dimentionSize.GetDescription());
        }

        private string BuildMargin(SpacingConfiguration spacingConfiguration, Enums.Spacing spacing)
        {
            return cssClassBuilder.BuildClass($"m{spacingConfiguration.Side.GetDescription()}", spacingConfiguration.Breakpoint.GetDescription(), spacing.GetDescription());
        }

        private string BuildPointerEvents(bool? pointerEvents)
        {
            if (!pointerEvents.HasValue)
                return null;
            return cssClassBuilder.BuildClass($"pe", pointerEvents.Value ? "auto" : "none");
        }

        private string BuildWidth(Enums.DimentionSize? dimentionSize)
        {
            if (!dimentionSize.HasValue)
                return null;
            return dimentionSize == Enums.DimentionSize.Viewport ? "vw-100" : cssClassBuilder.BuildClass("w", dimentionSize.GetDescription());
        }
    }
}
