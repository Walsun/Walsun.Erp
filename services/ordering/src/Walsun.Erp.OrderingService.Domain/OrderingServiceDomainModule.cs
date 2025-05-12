using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Walsun.Erp.OrderingService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(OrderingServiceDomainSharedModule)
)]
public class OrderingServiceDomainModule : AbpModule
{

}