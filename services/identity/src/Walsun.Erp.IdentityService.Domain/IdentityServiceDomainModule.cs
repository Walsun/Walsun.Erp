using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Walsun.Erp.IdentityService
{
    [DependsOn(
        typeof(IdentityServiceDomainSharedModule),
        typeof(AbpIdentityDomainModule)
    )]
    public class IdentityServiceDomainModule : AbpModule
    {
    }
}