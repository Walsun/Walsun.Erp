using Walsun.Erp.PaymentService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Walsun.Erp.PaymentService
{
    public abstract class PaymentServiceController : AbpControllerBase
    {
        protected PaymentServiceController()
        {
            LocalizationResource = typeof(PaymentServiceResource);
        }
    }
}
