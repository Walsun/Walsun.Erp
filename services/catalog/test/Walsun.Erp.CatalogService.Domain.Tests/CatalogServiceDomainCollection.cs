using Walsun.Erp.CatalogService.MongoDB;
using Xunit;

namespace Walsun.Erp.CatalogService;

[CollectionDefinition(CatalogServiceTestConsts.CollectionDefinitionName)]
public class CatalogServiceDomainCollection : CatalogServiceMongoDbCollectionFixtureBase
{

}