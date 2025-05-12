using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Walsun.Erp.PaymentService
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(PaymentServiceDomainSharedModule)
    )]
    public class PaymentServiceDomainModule : AbpModule
    {

    }
}
