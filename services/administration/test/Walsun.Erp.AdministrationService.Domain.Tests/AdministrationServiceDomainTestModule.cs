using Walsun.Erp.AdministrationService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Walsun.Erp.AdministrationService
{
    [DependsOn(
        typeof(AdministrationServiceEntityFrameworkCoreTestModule)
        )]
    public class AdministrationServiceDomainTestModule : AbpModule
    {

    }
}