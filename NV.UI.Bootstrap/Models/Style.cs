using NV.UI.Bootstrap.Classes;
using System.Collections.Generic;

namespace NV.UI.Bootstrap.Models
{
    public class Style
    {
        public bool Active { get; set; }
        public Enums.BackgroundColour? BackgroundColour { get; set; }
        public bool BackgroundGradient { get; set; }
        public Enums.Context? BorderColour { get; set; }
        public Enums.BorderWidth? BorderWidth { get; set; }
        public Dictionary<Enums.Breakpoint, Enums.Columns?> Columns { get; set; } = new();
        public Dictionary<Enums.Breakpoint, Enums.Display> Display { get; set; } = new();
        public Dictionary<Enums.Breakpoint, Enums.FlexContentAlign> FlexAlignContent { get; set; } = new();
        public Dictionary<Enums.Breakpoint, Enums.FlexAlign> FlexAlignItems { get; set; } = new();
        public Dictionary<Enums.Breakpoint, Enums.FlexAlign> FlexAlignSelf { get; set; } = new();
        public Dictionary<Enums.Breakpoint, Enums.FlexDirection> FlexDirection { get; set; } = new();
        public List<Enums.Breakpoint> FlexFill { get; set; } = new();
        public Dictionary<Enums.Breakpoint, bool> FlexGrow { get; set; } = new();
        public Dictionary<Enums.Breakpoint, Enums.FlexContentAlign> FlexJustifyContent { get; set; } = new();
        public Dictionary<Enums.Breakpoint, bool> FlexShrink { get; set; } = new();
        public Dictionary<Enums.Breakpoint, Enums.FlexWrap> FlexWrap { get; set; } = new();
        public bool? FontItalic { get; set; }
        public Enums.FontSize? FontSize { get; set; }
        public Enums.FontWeight? FontWeight { get; set; }
        public Dictionary<Enums.Breakpoint, Enums.Spacing> Gap { get; set; } = new();
        public Dictionary<GutterConfiguration, Enums.Spacing> Gutters { get; set; } = new();
        public Enums.DimentionSize? Height { get; set; }
        public Dictionary<SpacingConfiguration, Enums.Spacing> Margins { get; set; } = new();
        public bool MaxHeight { get; set; }
        public bool MaxWidth { get; set; }
        public bool MinViewportHeight { get; set; }
        public bool MinViewportWidth { get; set; }
        public Dictionary<Enums.Breakpoint, Enums.Columns> Offsets { get; set; } = new();
        public Enums.Opacity? Opacity { get; set; }
        public Dictionary<Enums.Breakpoint, Enums.Order> Order { get; set; } = new();
        public bool? PointerEvents { get; set; }
        public Enums.Rounded? Rounded { get; set; }
        public Dictionary<Enums.Breakpoint, Enums.RowColumns> RowColumns { get; set; } = new();
        public Enums.ShadowSize? Shadow { get; set; }
        public Dictionary<Enums.Breakpoint, Enums.TextAlignment> TextAlignment { get; set; } = new();
        public Enums.TextColour? TextColour { get; set; }
        public Enums.DimentionSize? Width { get; set; }

        internal Style Clone()
        {
            return new Style()
            {
                Active = Active,
                BackgroundColour = BackgroundColour,
                BackgroundGradient = BackgroundGradient,
                BorderColour = BorderColour,
                BorderWidth = BorderWidth,
                Columns = Columns,
                Display = Display,
                FlexAlignContent = FlexAlignContent,
                FlexAlignItems = FlexAlignItems,
                FlexAlignSelf = FlexAlignSelf,
                FlexDirection = FlexDirection,
                FlexFill = FlexFill,
                FlexGrow = FlexGrow,
                FlexJustifyContent = FlexJustifyContent,
                FlexShrink = FlexShrink,
                FlexWrap = FlexWrap,
                FontItalic = FontItalic,
                FontSize = FontSize,
                FontWeight = FontWeight,
                Gap = Gap,
                Gutters = Gutters,
                Height = Height,
                Margins = Margins,
                MaxHeight = MaxHeight,
                MaxWidth = MaxWidth,
                MinViewportHeight = MinViewportHeight,
                MinViewportWidth = MinViewportWidth,
                Offsets = Offsets,
                Opacity = Opacity,
                Order = Order,
                PointerEvents = PointerEvents,
                Rounded = Rounded,
                RowColumns = RowColumns,
                Shadow = Shadow,
                TextAlignment = TextAlignment,
                TextColour = TextColour,
                Width  = Width
            };
        }
    }
}
