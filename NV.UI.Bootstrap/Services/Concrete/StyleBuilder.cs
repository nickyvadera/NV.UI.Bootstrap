using NV.UI.Bootstrap.Classes;
using NV.UI.Bootstrap.Models;
using NV.UI.Bootstrap.Services.Abstract;
using System;
using System.Collections.Generic;

namespace NV.UI.Bootstrap.Services.Concrete
{
    public class StyleBuilder : IStyleBuilder
    {
        protected readonly List<Action<Style>> styleTransformations = new();

        public Style Build(Style baseStyle = null)
        {
            var style = baseStyle ?? new Style();
            foreach(var transformation in styleTransformations)
                transformation(style);
            return style;
        }

        public IStyleBuilder WithActive(bool active = true)
        {
            styleTransformations.Add(ActiveAction(active));
            return this;
        }

        public IStyleBuilder WithBackground(Enums.BackgroundColour? colour, bool gradient = false)
        {
            styleTransformations.Add(BackgroundAction(colour, gradient));
            return this;
        }

        public IStyleBuilder WithBorderColour(Enums.Context? colour)
        {
            styleTransformations.Add(BorderColourAction(colour));
            return this;
        }

        public IStyleBuilder WithBorderWidth(Enums.BorderWidth? width)
        {
            styleTransformations.Add(BorderWidthAction(width));
            return this;
        }

        public IStyleBuilder WithDisplay(Enums.Display display, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(DisplayAction(display, breakpoint));
            return this;
        }

        public IStyleBuilder WithFlex(Enums.FlexDirection? direction = null, Enums.FlexAlign? alignItems = null, Enums.FlexContentAlign? justifyContent = null, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            WithDisplay(Enums.Display.Flex, breakpoint);
            if(direction.HasValue)
                WithFlexDirection(direction.Value, breakpoint);
            if(alignItems.HasValue)
                WithFlexAlignItems(alignItems.Value, breakpoint);
            if(justifyContent.HasValue)
                WithFlexJustifyContent(justifyContent.Value, breakpoint);
            return this;
        }

        public IStyleBuilder WithFlexAlignContent(Enums.FlexContentAlign alignment, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(FlexAlignContentAction(alignment, breakpoint));
            return this;
        }

        public IStyleBuilder WithFlexAlignItems(Enums.FlexAlign alignment, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(FlexAlignItemsAction(alignment, breakpoint));
            return this;
        }

        public IStyleBuilder WithFlexAlignSelf(Enums.FlexAlign alignment, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(FlexAlignSelfAction(alignment, breakpoint));
            return this;
        }

        public IStyleBuilder WithFlexDirection(Enums.FlexDirection direction, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(FlexDirectionAction(direction, breakpoint));
            return this;
        }

        public IStyleBuilder WithFlexFill(bool fill = true, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(FlexFillAction(fill, breakpoint));
            return this;
        }

        public IStyleBuilder WithFlexGrow(bool grow = true, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(FlexGrowAction(grow, breakpoint));
            return this;
        }

        public IStyleBuilder WithFlexJustifyContent(Enums.FlexContentAlign alignment, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(FlexJustifyContentAction(alignment, breakpoint));
            return this;
        }

        public IStyleBuilder WithFlexShrink(bool shrink = true, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(FlexShrinkAction(shrink, breakpoint));
            return this;
        }

        public IStyleBuilder WithFlexWrap(Enums.FlexWrap wrap = Enums.FlexWrap.Wrap, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(FlexWrapAction(wrap, breakpoint));
            return this;
        }

        public IStyleBuilder WithFontItalic(bool? italic = true)
        {
            styleTransformations.Add(FontItalicAction(italic));
            return this;
        }

        public IStyleBuilder WithFontSize(Enums.FontSize? size)
        {
            styleTransformations.Add(FontSizeAction(size));
            return this;
        }

        public IStyleBuilder WithFontWeight(Enums.FontWeight? weight)
        {
            styleTransformations.Add(FontWeightAction(weight));
            return this;
        }

        public IStyleBuilder WithGap(Enums.Spacing spacing, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(GapAction(spacing, breakpoint));
            return this;
        }

        public IStyleBuilder WithGrid(Enums.Spacing? gap = null, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            WithDisplay(Enums.Display.Grid, breakpoint);
            if(gap.HasValue)
                WithGap(gap.Value, breakpoint);
            return this;
        }

        public IStyleBuilder WithHeight(Enums.DimentionSize height)
        {
            styleTransformations.Add(HeightAction(height));
            return this;
        }

        public IStyleBuilder WithMargin(Enums.Spacing spacing, Enums.Side? side = null, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(MarginAction(spacing, new SpacingConfiguration(breakpoint, side)));
            return this;
        }

        public IStyleBuilder WithMaxHeight(bool maxHeight = true)
        {
            styleTransformations.Add(MaxHeightAction(maxHeight));
            return this;
        }

        public IStyleBuilder WithMaxWidth(bool maxWidth = true)
        {
            styleTransformations.Add(MaxWidthAction(maxWidth));
            return this;
        }

        public IStyleBuilder WithMinViewportHeight(bool minViewportHeight = true)
        {
            styleTransformations.Add(MinViewportHeightAction(minViewportHeight));
            return this;
        }

        public IStyleBuilder WithMinViewportWidth(bool minViewportWidth = true)
        {
            styleTransformations.Add(MinViewportWidthAction(minViewportWidth));
            return this;
        }

        public IStyleBuilder WithOpacity(Enums.Opacity? opacity)
        {
            styleTransformations.Add(OpacityAction(opacity));
            return this;
        }

        public IStyleBuilder WithOrder(Enums.Order order, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(OrderAction(order, breakpoint));
            return this;
        }

        public IStyleBuilder WithPointerEvents(bool? enabled)
        {
            styleTransformations.Add(PointerEventsAction(enabled));
            return this;
        }

        public IStyleBuilder WithRounded(Enums.Rounded? rounded = Enums.Rounded.Default)
        {
            styleTransformations.Add(RoundedAction(rounded));
            return this;
        }

        public IStyleBuilder WithShadow(Enums.ShadowSize? size = Enums.ShadowSize.Default)
        {
            styleTransformations.Add(ShadowAction(size));
            return this;
        }

        public IStyleBuilder WithTextAlignment(Enums.TextAlignment alignment, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default)
        {
            styleTransformations.Add(TextAlignmentAction(alignment, breakpoint));
            return this;
        }

        public IStyleBuilder WithTextColour(Enums.TextColour? textColour)
        {
            styleTransformations.Add(TextColourAction(textColour));
            return this;
        }

        public IStyleBuilder WithWidth(Enums.DimentionSize width)
        {
            styleTransformations.Add(WidthAction(width));
            return this;
        }

        private static Action<Style> ActiveAction(bool active)
        {
            return style => style.Active = active;
        }

        private static Action<Style> BackgroundAction(Enums.BackgroundColour? colour, bool gradient)
        {
            return style =>
            {
                style.BackgroundColour = colour;
                style.BackgroundGradient = gradient;
            };
        }

        private static Action<Style> BorderColourAction(Enums.Context? colour)
        {
            return style => style.BorderColour = colour;
        }

        private static Action<Style> BorderWidthAction(Enums.BorderWidth? width)
        {
            return style => style.BorderWidth = width;
        }

        private static Action<Style> DisplayAction(Enums.Display display, Enums.Breakpoint breakpoint)
        {
            return style => style.Display[breakpoint] = display;
        }

        private static Action<Style> FlexAlignContentAction(Enums.FlexContentAlign alignment, Enums.Breakpoint breakpoint)
        {
            return style => style.FlexAlignContent[breakpoint] = alignment;
        }

        private static Action<Style> FlexAlignItemsAction(Enums.FlexAlign alignment, Enums.Breakpoint breakpoint)
        {
            return style => style.FlexAlignItems[breakpoint] = alignment;
        }

        private static Action<Style> FlexAlignSelfAction(Enums.FlexAlign alignment, Enums.Breakpoint breakpoint)
        {
            return style => style.FlexAlignSelf[breakpoint] = alignment;
        }

        private static Action<Style> FlexDirectionAction(Enums.FlexDirection direction, Enums.Breakpoint breakpoint)
        {
            return style => style.FlexDirection[breakpoint] = direction;
        }

        private static Action<Style> FlexFillAction(bool fill, Enums.Breakpoint breakpoint)
        {
            return style =>
            {
                if(fill)
                    style.FlexFill.Add(breakpoint);
                else
                    style.FlexFill.Remove(breakpoint);
            };
        }

        private static Action<Style> FlexGrowAction(bool grow, Enums.Breakpoint breakpoint)
        {
            return style => style.FlexGrow[breakpoint] = grow;
        }

        private static Action<Style> FlexJustifyContentAction(Enums.FlexContentAlign alignment, Enums.Breakpoint breakpoint)
        {
            return style => style.FlexJustifyContent[breakpoint] = alignment;
        }

        private static Action<Style> FlexShrinkAction(bool shrink, Enums.Breakpoint breakpoint)
        {
            return style => style.FlexShrink[breakpoint] = shrink;
        }

        private static Action<Style> FlexWrapAction(Enums.FlexWrap wrap, Enums.Breakpoint breakpoint)
        {
            return style => style.FlexWrap[breakpoint] = wrap;
        }

        private static Action<Style> FontItalicAction(bool? italic)
        {
            return style => style.FontItalic = italic;
        }

        private static Action<Style> FontSizeAction(Enums.FontSize? size)
        {
            return style => style.FontSize = size;
        }

        private static Action<Style> FontWeightAction(Enums.FontWeight? weight)
        {
            return style => style.FontWeight = weight;
        }

        private static Action<Style> GapAction(Enums.Spacing spacing, Enums.Breakpoint breakpoint)
        {
            return style => style.Gap[breakpoint] = spacing;
        }

        private static Action<Style> HeightAction(Enums.DimentionSize height)
        {
            return style => style.Height = height;
        }

        private static Action<Style> MarginAction(Enums.Spacing spacing, SpacingConfiguration configuration)
        {
            return style => style.Margins[configuration] = spacing;
        }

        private static Action<Style> MaxHeightAction(bool maxHeight)
        {
            return style => style.MaxHeight = maxHeight;
        }

        private static Action<Style> MaxWidthAction(bool maxWidth)
        {
            return style => style.MaxWidth = maxWidth;
        }

        private static Action<Style> MinViewportHeightAction(bool minViewportHeight)
        {
            return style => style.MinViewportHeight = minViewportHeight;
        }

        private static Action<Style> MinViewportWidthAction(bool minViewportWidth)
        {
            return style => style.MinViewportWidth = minViewportWidth;
        }

        private static Action<Style> OpacityAction(Enums.Opacity? opacity)
        {
            return style => style.Opacity = opacity;
        }

        private static Action<Style> OrderAction(Enums.Order order, Enums.Breakpoint breakpoint)
        {
            return style => style.Order[breakpoint] = order;
        }

        private static Action<Style> PointerEventsAction(bool? enabled)
        {
            return style => style.PointerEvents = enabled;
        }

        private static Action<Style> RoundedAction(Enums.Rounded? rounded)
        {
            return style => style.Rounded = rounded;
        }

        private static Action<Style> ShadowAction(Enums.ShadowSize? size)
        {
            return style => style.Shadow = size;
        }

        private static Action<Style> TextAlignmentAction(Enums.TextAlignment alignment, Enums.Breakpoint breakpoint)
        {
            return style => style.TextAlignment[breakpoint] = alignment;
        }

        private static Action<Style> TextColourAction(Enums.TextColour? textColour)
        {
            return style => style.TextColour = textColour;
        }

        private static Action<Style> WidthAction(Enums.DimentionSize width)
        {
            return style => style.Width = width;
        }
    }
}
