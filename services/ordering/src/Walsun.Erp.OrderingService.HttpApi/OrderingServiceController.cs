using Walsun.Erp.OrderingService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Walsun.Erp.OrderingService;

public abstract class OrderingServiceController : AbpControllerBase
{
    protected OrderingServiceController()
    {
        LocalizationResource = typeof(OrderingServiceResource);
    }
}