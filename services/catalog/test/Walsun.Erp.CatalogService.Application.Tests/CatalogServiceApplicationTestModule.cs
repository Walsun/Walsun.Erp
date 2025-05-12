using Volo.Abp.Modularity;

namespace Walsun.Erp.CatalogService
{
    [DependsOn(
        typeof(CatalogServiceApplicationModule),
        typeof(CatalogServiceDomainTestModule)
        )]
    public class CatalogServiceApplicationTestModule : AbpModule
    {

    }
}