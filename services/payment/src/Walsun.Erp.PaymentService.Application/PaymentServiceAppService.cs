using Walsun.Erp.PaymentService.Localization;
using Volo.Abp.Application.Services;

namespace Walsun.Erp.PaymentService
{
    public abstract class PaymentServiceAppService : ApplicationService
    {
        protected PaymentServiceAppService()
        {
            LocalizationResource = typeof(PaymentServiceResource);
            ObjectMapperContext = typeof(PaymentServiceApplicationModule);
        }
    }
}
