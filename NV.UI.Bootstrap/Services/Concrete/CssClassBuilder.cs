using NV.UI.Bootstrap.Classes;
using NV.UI.Bootstrap.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NV.UI.Bootstrap.Services.Concrete
{
    public class CssClassBuilder : ICssClassBuilder
    {
        private readonly List<string> cssClasses = new();

        public void AddClass(params string[] cssClassParts)
        {
            var cssClass = BuildClass(cssClassParts);
            if (!string.IsNullOrEmpty(cssClass) && !cssClasses.Contains(cssClass))
                cssClasses.Add(cssClass);
        }

        public void AddClasses(IEnumerable<string> cssClasses)
        {
            foreach (var cssClass in cssClasses)
                AddClass(cssClass);
        }

        public void AddConditionalClass(bool condition, params string[] cssClassParts)
        {
            if (condition)
                AddClass(cssClassParts);
        }

        public void AddEnumClass(Enum conditionalEnum, params string[] cssClassPrefixParts)
        {
            if (conditionalEnum != null)
                AddClass(BuildClass(cssClassPrefixParts), conditionalEnum.GetDescription());
        }

        public IEnumerable<string> Build()
        {
            var cssClassesToReturn = cssClasses.ToList();
            cssClasses.Clear();
            return cssClassesToReturn;
        }

        public string BuildClass(params string[] cssClassParts)
        {
            return string.Join('-', cssClassParts.Where(s => !string.IsNullOrEmpty(s)));
        }
    }
}