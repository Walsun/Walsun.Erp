using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Walsun.Erp.Shared.Hosting.AspNetCore
{
    [Dependency(ReplaceServices = true)]
    public class WalsunErpBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "EShopOnAbp";
    }
}
