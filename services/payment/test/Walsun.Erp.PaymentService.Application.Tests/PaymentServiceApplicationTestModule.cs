using Volo.Abp.Modularity;

namespace Walsun.Erp.PaymentService
{
    [DependsOn(
        typeof(PaymentServiceApplicationModule),
        typeof(PaymentServiceDomainTestModule)
        )]
    public class PaymentServiceApplicationTestModule : AbpModule
    {

    }
}
