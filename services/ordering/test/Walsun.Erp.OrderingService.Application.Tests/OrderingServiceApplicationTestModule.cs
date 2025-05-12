using Volo.Abp.Modularity;

namespace Walsun.Erp.OrderingService
{
    [DependsOn(
        typeof(OrderingServiceApplicationModule),
        typeof(OrderingServiceDomainTestModule)
        )]
    public class OrderingServiceApplicationTestModule : AbpModule
    {

    }
}
