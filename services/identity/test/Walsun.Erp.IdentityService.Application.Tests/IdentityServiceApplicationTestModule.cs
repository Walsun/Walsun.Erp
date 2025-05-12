using Volo.Abp.Modularity;

namespace Walsun.Erp.IdentityService
{
    [DependsOn(
        typeof(IdentityServiceApplicationModule),
        typeof(IdentityServiceDomainTestModule)
        )]
    public class IdentityServiceApplicationTestModule : AbpModule
    {

    }
}