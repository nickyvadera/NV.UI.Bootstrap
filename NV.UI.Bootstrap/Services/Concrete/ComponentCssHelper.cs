using NV.UI.Bootstrap.Classes;
using NV.UI.Bootstrap.Services.Abstract;
using System;
using System.Collections.Generic;

namespace NV.UI.Bootstrap.Services.Concrete
{
    public class ComponentCssHelper : IComponentCssHelper
    {
        private readonly ICssClassBuilder cssClassBuilder;
        private readonly IStyleRenderer styleRenderer;
        private readonly string componentName;
        private readonly List<IStyleBuilder> styleBuilders = new();

        internal ComponentCssHelper(string componentName, ICssClassBuilder cssClassBuilder, IStyleRenderer styleRenderer)
        {
            this.componentName = componentName.ToLowerInvariant();
            this.cssClassBuilder = cssClassBuilder;
            this.styleRenderer = styleRenderer;
            cssClassBuilder.AddClass(componentName);
        }

        public IComponentCssHelper AddClass(params string[] cssClassParts)
        {
            cssClassBuilder.AddClass(cssClassParts);
            return this;
        }

        public IComponentCssHelper AddConditionalClass(bool condition, params string[] cssClassParts)
        {
            cssClassBuilder.AddConditionalClass(condition, cssClassParts);
            return this;
        }

        public IComponentCssHelper AddConditionalEnumModifier(bool condition, Enum enumValue)
        {
            if (condition)
                AddEnumModifier(enumValue);
            return this;
        }

        public IComponentCssHelper AddConditionalEnumModifier(bool condition, Enum enumValue, string modifier)
        {
            if (condition)
                AddEnumModifier(enumValue, modifier);
            return this;
        }

        public IComponentCssHelper AddConditionalModifier(bool condition, string modifier)
        {
            cssClassBuilder.AddConditionalClass(condition, componentName, modifier);
            return this;
        }

        public IComponentCssHelper AddEnumClass(Enum enumValue, string cssClassPrefix)
        {
            cssClassBuilder.AddEnumClass(enumValue, cssClassPrefix);
            return this;
        }

        public IComponentCssHelper AddEnumModifier(Enum enumValue)
        {
            if (!string.IsNullOrEmpty(enumValue.GetDescription()))
                cssClassBuilder.AddEnumClass(enumValue, componentName);
            return this;
        }

        public IComponentCssHelper AddEnumModifier(Enum enumValue, string modifier)
        {
            cssClassBuilder.AddEnumClass(enumValue, componentName, modifier);
            return this;
        }

        public IComponentCssHelper AddModifier(string modifier)
        {
            cssClassBuilder.AddClass(componentName, modifier);
            return this;
        }

        public IComponentCssHelper AddStyleBuilder(IStyleBuilder styleBuilder)
        {
            if (styleBuilder != null)
                styleBuilders.Add(styleBuilder);
            return this;
        }

        public string Build()
        {
            cssClassBuilder.AddClasses(styleRenderer.AsCssClasses(styleBuilders, componentName));
            styleBuilders.Clear();
            return string.Join(' ', cssClassBuilder.Build());
        }
    }
}
