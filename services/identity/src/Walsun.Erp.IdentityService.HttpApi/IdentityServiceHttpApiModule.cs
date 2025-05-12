using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Walsun.Erp.IdentityService
{
    [DependsOn(
        typeof(IdentityServiceApplicationContractsModule),
        typeof(AbpIdentityHttpApiModule)
    )]
    public class IdentityServiceHttpApiModule : AbpModule
    {
    }
}