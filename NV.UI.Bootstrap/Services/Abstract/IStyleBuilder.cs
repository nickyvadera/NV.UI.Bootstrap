using NV.UI.Bootstrap.Classes;
using NV.UI.Bootstrap.Models;

namespace NV.UI.Bootstrap.Services.Abstract
{
    public interface IStyleBuilder
    {
        Style Build(Style baseStyle = null); // todo: make internal?

        IStyleBuilder WithActive(bool active = true);

        IStyleBuilder WithBackground(Enums.BackgroundColour? colour, bool gradient = false);

        IStyleBuilder WithBorderColour(Enums.Context? colour);

        IStyleBuilder WithBorderWidth(Enums.BorderWidth? width);

        IStyleBuilder WithDisplay(Enums.Display display, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithFlex(Enums.FlexDirection? direction = null, Enums.FlexAlign? alignItems = null, Enums.FlexContentAlign? justifyContent = null, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithFlexAlignContent(Enums.FlexContentAlign alignment, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithFlexAlignItems(Enums.FlexAlign alignment, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithFlexAlignSelf(Enums.FlexAlign alignment, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithFlexDirection(Enums.FlexDirection direction, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithFlexFill(bool fill = true, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithFlexGrow(bool grow = true, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithFlexJustifyContent(Enums.FlexContentAlign alignment, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithFlexShrink(bool shrink = true, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithFlexWrap(Enums.FlexWrap wrap = Enums.FlexWrap.Wrap, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);
        
        IStyleBuilder WithFontItalic(bool? italic = true);

        IStyleBuilder WithFontSize(Enums.FontSize? size);

        IStyleBuilder WithFontWeight(Enums.FontWeight? weight);

        IStyleBuilder WithGrid(Enums.Spacing? gap = null, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithGap(Enums.Spacing spacing, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithHeight(Enums.DimentionSize height);

        IStyleBuilder WithMaxHeight(bool maxHeight = true);

        IStyleBuilder WithMaxWidth(bool maxWidth = true);

        IStyleBuilder WithMinViewportHeight(bool minViewportHeight = true);

        IStyleBuilder WithMinViewportWidth(bool minViewportWidth = true);

        IStyleBuilder WithOpacity(Enums.Opacity? opacity);

        IStyleBuilder WithMargin(Enums.Spacing spacing, Enums.Side? side = null, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithOrder(Enums.Order order, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithPointerEvents(bool? enabled);

        IStyleBuilder WithRounded(Enums.Rounded? rounded = Enums.Rounded.Default);

        IStyleBuilder WithShadow(Enums.ShadowSize? size = Enums.ShadowSize.Default);

        IStyleBuilder WithTextAlignment(Enums.TextAlignment alignment, Enums.Breakpoint breakpoint = Enums.Breakpoint.Default);

        IStyleBuilder WithTextColour(Enums.TextColour? textColour);

        IStyleBuilder WithWidth(Enums.DimentionSize width);
    }
}
