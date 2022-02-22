using NV.UI.Bootstrap.Classes;

namespace NV.UI.Bootstrap.Services.Abstract
{
    public interface IStyleHelper
    {
        Enums.BackgroundColour? GetBackgroundColour(Enums.Context? context);
        Enums.TextColour? GetTextColour(Enums.Context? context);
    }
}
