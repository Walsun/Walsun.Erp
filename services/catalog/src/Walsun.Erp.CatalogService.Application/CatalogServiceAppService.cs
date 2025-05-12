using Walsun.Erp.CatalogService.Localization;
using Volo.Abp.Application.Services;

namespace Walsun.Erp.CatalogService
{
    /* Inherit your application services from this class.
     */
    public abstract class CatalogServiceAppService : ApplicationService
    {
        protected CatalogServiceAppService()
        {
            LocalizationResource = typeof(CatalogServiceResource);
        }
    }
}
