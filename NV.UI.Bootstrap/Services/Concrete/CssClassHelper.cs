using NV.UI.Bootstrap.Services.Abstract;
using System;
using System.Collections.Generic;

namespace NV.UI.Bootstrap.Services.Concrete
{
    [Obsolete]
    public class CssClassHelper : ICssClassHelper
    {
        private readonly ICssClassBuilder cssClassBuilder;
        private readonly IStyleRenderer styleRenderer;
        private readonly List<IStyleBuilder> styleBuilders = new();

        public CssClassHelper(ICssClassBuilder cssClassBuilder, IStyleRenderer styleRenderer)
        {
            this.cssClassBuilder = cssClassBuilder;
            this.styleRenderer = styleRenderer;
        }

        public ICssClassHelper AddClass(params string[] cssClassParts)
        {
            cssClassBuilder.AddClass(cssClassParts);
            return this;
        }

        public ICssClassHelper AddConditionalClass(bool condition, params string[] cssClassParts)
        {
            cssClassBuilder.AddConditionalClass(condition, cssClassParts);
            return this;
        }

        public ICssClassHelper AddConditionalClass(Enum conditionalEnum, string cssClassPrefix)
        {
            cssClassBuilder.AddEnumClass(conditionalEnum, cssClassPrefix);
            return this;
        }

        public ICssClassHelper AddStyleBuilder(IStyleBuilder styleBuilder)
        {
            if (styleBuilder != null)
                styleBuilders.Add(styleBuilder);
            return this;
        }

        public string Build()
        {
            cssClassBuilder.AddClasses(styleRenderer.AsCssClasses(styleBuilders));
            styleBuilders.Clear();
            return string.Join(' ', cssClassBuilder.Build());
        }
    }
}