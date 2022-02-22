using System.ComponentModel;

namespace NV.UI.Bootstrap.Classes
{
    public class Enums
    {
        public enum Component { Badge, Button }

        public enum Axis { X, Y }

        public enum BackgroundColour
        {
            Primary,
            Secondary,
            Success,
            Danger,
            Warning,
            Info,
            Light,
            Dark,
            Body,
            White,
            Transparent
        }

        public enum BorderWidth
        {
            [Description("0")]
            Zero,
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four,
            [Description("5")]
            Five
        }

        public enum Breakpoint
        {
            [Description(null)]
            Default,
            [Description("sm")]
            Small,
            [Description("md")]
            Medium,
            [Description("lg")]
            Large,
            [Description("xl")]
            ExtraLarge,
            [Description("xxl")]
            ExtraExtraLarge
        }

        public enum ButtonContext
        {
            Primary,
            Secondary,
            Success,
            Danger,
            Warning,
            Info,
            Light,
            Dark,
            Link
        }

        public enum Columns
        {
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four,
            [Description("5")]
            Five,
            [Description("6")]
            Six,
            [Description("7")]
            Seven,
            [Description("8")]
            Eight,
            [Description("9")]
            Nine,
            [Description("10")]
            Ten,
            [Description("11")]
            Eleven,
            [Description("12")]
            Twelve,
            [Description("auto")]
            Auto
        }

        public enum Context
        {
            Primary,
            Secondary,
            Success,
            Danger,
            Warning,
            Info,
            Light,
            Dark,
            White
        }

        public enum DimentionSize
        {
            [Description("25")]
            Percent25,
            [Description("50")]
            Percent50,
            [Description("75")]
            Percent75,
            [Description("100")]
            Percent100,
            Auto,
            Viewport
        }

        public enum Display
        {
            None,
            Inline,
            [Description("inline-block")]
            InlineBlock,
            Block,
            Grid,
            Table,
            [Description("table-cell")]
            TableCell,
            [Description("table-row")]
            TableRow,
            Flex,
            [Description("inline-flex")]
            InlineFlex
        }

        public enum FlexAlign
        {
            Start,
            End,
            Center,
            Baseline,
            Stretch
        }

        public enum FlexContentAlign
        {
            Start,
            End,
            Center,
            Between,
            Around,
            Evenly,
            Stretch
        }

        public enum FlexDirection
        {
            Row,
            [Description("row-reverse")]
            RowReverse,
            Column,
            [Description("column-reverse")]
            ColumnReverse
        }

        public enum FlexWrap
        {
            NoWrap,
            Wrap,
            [Description("wrap-reverse")]
            WrapReverse
        }

        public enum FontSize
        {
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four,
            [Description("5")]
            Five,
            [Description("6")]
            Six
        }

        public enum FontWeight
        {
            Bold,
            Bolder,
            Normal,
            Light,
            Lighter
        }

        public enum Opacity
        {
            [Description("0")]
            Percent0,
            [Description("25")]
            Percent25,
            [Description("50")]
            Percent50,
            [Description("75")]
            Percent75,
            [Description("100")]
            Percent100
        }

        public enum Order
        {
            [Description("0")]
            Zero,
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four,
            [Description("5")]
            Five,
            First,
            Last
        }

        public enum Rounded
        {
            [Description(null)]
            Default,
            [Description("0")]
            Zero,
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            Top,
            End,
            Bottom,
            Start,
            Circle,
            Pill
        }

        public enum RowColumns
        {
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four,
            [Description("5")]
            Five,
            [Description("6")]
            Six,
            [Description("auto")]
            Auto
        }

        public enum ShadowSize
        {
            [Description(null)]
            Default,
            [Description("none")]
            None,
            [Description("sm")]
            Small,
            [Description("lg")]
            Large
        }

        public enum Side
        {
            [Description("t")]
            Top,
            [Description("b")]
            Bottom,
            [Description("s")]
            Start,
            [Description("e")]
            End,
            [Description("x")]
            X,
            [Description("y")]
            Y
        }

        public enum Size {
            [Description(null)]
            Default,
            [Description("sm")]
            Small,
            [Description("lg")]
            Large 
        }

        public enum Spacing {
            [Description("0")]
            Zero,
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four,
            [Description("5")]
            Five,
            [Description("auto")]
            Auto
        }

        public enum TextAlignment
        {
            Start,
            End,
            Center
        }

        public enum TextColour
        {
            Primary,
            Secondary,
            Success,
            Danger,
            Warning,
            Info,
            Light,
            Dark,
            Body,
            Muted,
            White,
            [Description("black-50")]
            Black50,
            [Description("white-50")]
            White50,
            Reset
        }
    }
}
