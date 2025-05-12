using Walsun.Erp.CmskitService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Walsun.Erp.CmskitService;

public abstract class CmskitServiceController : AbpControllerBase
{
    protected CmskitServiceController()
    {
        LocalizationResource = typeof(CmskitServiceResource);
    }
}
