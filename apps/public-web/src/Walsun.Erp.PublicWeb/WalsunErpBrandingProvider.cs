using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Walsun.Erp.PublicWeb;

[Dependency(ReplaceServices = true)]
public class WalsunErpBrandingProvider: DefaultBrandingProvider
{
    public override string AppName => "WalsunErp";
}