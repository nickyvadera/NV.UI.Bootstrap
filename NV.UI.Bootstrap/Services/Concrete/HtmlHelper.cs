using NV.UI.Bootstrap.Services.Abstract;
using System;

namespace NV.UI.Bootstrap.Services.Concrete
{
    public class HtmlHelper : IHtmlHelper
    {
        public string GenerateId()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray())
                .Replace('=', '_')
                .Replace('/', '_');
        }
    }
}
