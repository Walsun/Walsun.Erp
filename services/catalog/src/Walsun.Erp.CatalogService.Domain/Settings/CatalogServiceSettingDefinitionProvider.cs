using Volo.Abp.Settings;

namespace Walsun.Erp.CatalogService.Settings
{
    public class CatalogServiceSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CatalogServiceSettings.MySetting1));
        }
    }
}
