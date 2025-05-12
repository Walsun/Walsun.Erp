using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Walsun.Erp.OrderingService.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;
using Walsun.Erp.PaymentService;

namespace Walsun.Erp.OrderingService;

[DependsOn(
    typeof(AbpValidationModule),
    typeof(PaymentServiceDomainSharedModule)
)]
public class OrderingServiceDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<OrderingServiceDomainSharedModule>();
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<OrderingServiceResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/OrderingService");
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("OrderingService", typeof(OrderingServiceResource));
        });
    }
}