using Microsoft.Extensions.Configuration;
using NV.UI.Bootstrap.Models;
using NV.UI.Bootstrap.Services.Abstract;
using NV.UI.Bootstrap.Services.Concrete;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUIBootstrap(this IServiceCollection services, IConfiguration bootstrapSettingsConfiguration)
        {
            services.AddTransient<IComponentCssHelperFactory, ComponentCssHelperFactory>()
                .AddTransient<ICssClassBuilder, CssClassBuilder>()
                .AddTransient<IHtmlHelper, HtmlHelper>()
                .AddTransient<IStyleBuilderFactory, StyleBuilderFactory>()
                .AddTransient<IStyleHelper, StyleHelper>()
                .AddTransient<IStyleRenderer, StyleRenderer>();

            services.Configure<BootstrapSettingsOptions>(bootstrapSettingsConfiguration);

            return services;
        }
    }
}
