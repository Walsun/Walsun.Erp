using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;
using Volo.Abp.VirtualFileSystem;

namespace Walsun.Erp.Shared.Hosting.AspNetCore;

[DependsOn(
    typeof(WalsunErpSharedHostingModule),
    typeof(WalsunErpSharedLocalizationModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpSwashbuckleModule)
)]
public class WalsunErpSharedHostingAspNetCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<WalsunErpSharedHostingAspNetCoreModule>("Walsun.Erp.Shared.Hosting.AspNetCore");
        });
    }
}