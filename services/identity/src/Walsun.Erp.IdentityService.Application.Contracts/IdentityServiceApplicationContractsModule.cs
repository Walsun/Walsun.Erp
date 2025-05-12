using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Walsun.Erp.IdentityService
{
    [DependsOn(
        typeof(IdentityServiceDomainSharedModule),
        typeof(AbpIdentityApplicationContractsModule)
    )]
    public class IdentityServiceApplicationContractsModule : AbpModule
    {
    }
}
