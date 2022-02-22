using NV.UI.Bootstrap.Services.Abstract;

namespace NV.UI.Bootstrap.Services.Concrete
{
    public class ComponentCssHelperFactory : IComponentCssHelperFactory
    {
        
        private readonly ICssClassBuilder cssClassBuilder;
        private readonly IStyleRenderer styleRenderer;

        public ComponentCssHelperFactory(ICssClassBuilder cssClassBuilder, IStyleRenderer styleRenderer)
        {
            
            this.cssClassBuilder = cssClassBuilder;
            this.styleRenderer = styleRenderer;
        }

        public IComponentCssHelper Create(string componentName)
        {
            return new ComponentCssHelper(componentName, cssClassBuilder, styleRenderer);
        }
    }
}
