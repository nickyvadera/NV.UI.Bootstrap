using System;

namespace NV.UI.Bootstrap.Services.Abstract
{
    [Obsolete]
    public interface ICssClassHelper
    {
        ICssClassHelper AddClass(params string[] cssClass);

        ICssClassHelper AddConditionalClass(bool condition, params string[] cssClass);

        ICssClassHelper AddConditionalClass(Enum conditionalEnum, string cssClassPrefix);

        ICssClassHelper AddStyleBuilder(IStyleBuilder styleBuilder);

        string Build();
    }
}
