using Walsun.Erp.CmskitService.Localization;
using Volo.Abp.Application.Services;

namespace Walsun.Erp.CmskitService;

public abstract class CmskitServiceAppService : ApplicationService
{
    protected CmskitServiceAppService()
    {
        LocalizationResource = typeof(CmskitServiceResource);
        ObjectMapperContext = typeof(CmskitServiceApplicationModule);
    }
}
