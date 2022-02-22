using System.Collections.Generic;

namespace NV.UI.Bootstrap.Models
{
    public class BootstrapSettingsOptions
    {
        public const string BootstrapSettings = "BootstrapSettings";

        public IDictionary<string, Style> ComponentStyles { get; set; }
    }
}
