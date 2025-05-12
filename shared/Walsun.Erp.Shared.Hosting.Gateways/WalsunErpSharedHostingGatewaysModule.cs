using Walsun.Erp.Shared.Hosting.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Walsun.Erp.Shared.Hosting.Gateways
{
    [DependsOn(
        typeof(WalsunErpSharedHostingAspNetCoreModule)
    )]
    public class WalsunErpSharedHostingGatewaysModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            context.Services.AddHttpForwarderWithServiceDiscovery();
            
            context.Services.AddReverseProxy()
                .LoadFromConfig(configuration.GetSection("ReverseProxy"))
                .AddServiceDiscoveryDestinationResolver();
        }
    }
}