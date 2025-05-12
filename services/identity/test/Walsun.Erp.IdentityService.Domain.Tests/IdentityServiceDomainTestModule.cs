using Walsun.Erp.IdentityService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Walsun.Erp.IdentityService
{
    [DependsOn(
        typeof(IdentityServiceEntityFrameworkCoreTestModule)
        )]
    public class IdentityServiceDomainTestModule : AbpModule
    {

    }
}