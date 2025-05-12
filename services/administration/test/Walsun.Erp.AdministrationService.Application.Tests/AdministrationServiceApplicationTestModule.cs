using Volo.Abp.Modularity;

namespace Walsun.Erp.AdministrationService
{
    [DependsOn(
        typeof(AdministrationServiceApplicationModule),
        typeof(AdministrationServiceDomainTestModule)
        )]
    public class AdministrationServiceApplicationTestModule : AbpModule
    {

    }
}