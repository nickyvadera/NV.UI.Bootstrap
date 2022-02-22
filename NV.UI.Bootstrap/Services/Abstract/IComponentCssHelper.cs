using System;

namespace NV.UI.Bootstrap.Services.Abstract
{
    public interface IComponentCssHelper
    {
        IComponentCssHelper AddClass(params string[] cssClassParts);

        IComponentCssHelper AddConditionalClass(bool condition, params string[] cssClassParts);

        IComponentCssHelper AddConditionalEnumModifier(bool condition, Enum enumValue);

        IComponentCssHelper AddConditionalEnumModifier(bool condition, Enum enumValue, string modifier);

        IComponentCssHelper AddConditionalModifier(bool condition, string modifier);

        IComponentCssHelper AddEnumClass(Enum conditionalEnum, string cssClassPrefix);

        IComponentCssHelper AddEnumModifier(Enum enumValue);

        IComponentCssHelper AddEnumModifier(Enum enumValue, string modifier);

        IComponentCssHelper AddModifier(string modifier);

        IComponentCssHelper AddStyleBuilder(IStyleBuilder styleBuilder);

        string Build();
    }
}
