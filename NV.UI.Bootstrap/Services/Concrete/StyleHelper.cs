using NV.UI.Bootstrap.Classes;
using NV.UI.Bootstrap.Services.Abstract;

namespace NV.UI.Bootstrap.Services.Concrete
{
    public class StyleHelper : IStyleHelper
    {
        public Enums.BackgroundColour? GetBackgroundColour(Enums.Context? context)
        {
            return context switch
            {
                Enums.Context.Primary => Enums.BackgroundColour.Primary,
                Enums.Context.Secondary => Enums.BackgroundColour.Secondary,
                Enums.Context.Success => Enums.BackgroundColour.Success,
                Enums.Context.Danger => Enums.BackgroundColour.Danger,
                Enums.Context.Warning => Enums.BackgroundColour.Warning,
                Enums.Context.Info => Enums.BackgroundColour.Info,
                Enums.Context.Light => Enums.BackgroundColour.Light,
                Enums.Context.Dark => Enums.BackgroundColour.Dark,
                Enums.Context.White => Enums.BackgroundColour.White,
                _ => null,
            };
        }

        public Enums.TextColour? GetTextColour(Enums.Context? context)
        {
            return context switch
            {
                Enums.Context.Primary => Enums.TextColour.Primary,
                Enums.Context.Secondary => Enums.TextColour.Secondary,
                Enums.Context.Success => Enums.TextColour.Success,
                Enums.Context.Danger => Enums.TextColour.Danger,
                Enums.Context.Warning => Enums.TextColour.Warning,
                Enums.Context.Info => Enums.TextColour.Info,
                Enums.Context.Light => Enums.TextColour.Light,
                Enums.Context.Dark => Enums.TextColour.Dark,
                Enums.Context.White => Enums.TextColour.White,
                _ => null,
            };
        }
    }
}
