using Walsun.Erp.CatalogService.MongoDB;
using Volo.Abp.Modularity;

namespace Walsun.Erp.CatalogService
{
    [DependsOn(
        typeof(CatalogServiceMongoDbTestModule)
        )]
    public class CatalogServiceDomainTestModule : AbpModule
    {

    }
}