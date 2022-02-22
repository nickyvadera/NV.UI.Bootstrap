using System;
using System.Collections.Generic;

namespace NV.UI.Bootstrap.Services.Abstract
{
    public interface ICssClassBuilder
    {
        void AddClass(params string[] cssClassParts);

        void AddClasses(IEnumerable<string> cssClasses);

        void AddConditionalClass(bool condition, params string[] cssClassParts);

        void AddEnumClass(Enum conditionalEnum, params string[] cssClassPrefixParts);

        IEnumerable<string> Build();

        string BuildClass(params string[] cssClassParts);
    }
}
