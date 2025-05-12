using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;

// using Walsun.Erp.CatalogService;
// using Walsun.Erp.OrderingService;
// using Walsun.Erp.CmskitService;

namespace Walsun.Erp.AdministrationService
{
    [DependsOn(
        typeof(AdministrationServiceDomainSharedModule),
        typeof(AbpPermissionManagementApplicationContractsModule),
        typeof(AbpSettingManagementApplicationContractsModule)
        // typeof(CatalogServiceApplicationContractsModule),
        // typeof(OrderingServiceApplicationContractsModule),
        // typeof(CmskitServiceApplicationContractsModule)
    )]
    public class AdministrationServiceApplicationContractsModule : AbpModule
    {
    }
}