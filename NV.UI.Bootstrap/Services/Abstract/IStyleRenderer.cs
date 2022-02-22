using System.Collections.Generic;

namespace NV.UI.Bootstrap.Services.Abstract
{
    public interface IStyleRenderer
    {
        IEnumerable<string> AsCssClasses(IEnumerable<IStyleBuilder> styleBuilders, string componentName = null);
    }
}
