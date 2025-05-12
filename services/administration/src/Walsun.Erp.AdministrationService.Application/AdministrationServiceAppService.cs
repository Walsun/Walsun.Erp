using System;
using System.Collections.Generic;
using System.Text;
using Walsun.Erp.AdministrationService.Localization;
using Volo.Abp.Application.Services;

namespace Walsun.Erp.AdministrationService
{
    /* Inherit your application services from this class.
     */
    public abstract class AdministrationServiceAppService : ApplicationService
    {
        protected AdministrationServiceAppService()
        {
            LocalizationResource = typeof(AdministrationServiceResource);
        }
    }
}
