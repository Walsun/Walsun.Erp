using Walsun.Erp.Shared.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Walsun.Erp.DbMigrator;

[DependsOn(
    typeof(WalsunErpSharedHostingModule)
)]
public class WalsunErpDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var configuration = context.Services.GetConfiguration();

        Configure<KeycloakClientOptions>(options =>
            {
                options.Url = configuration["Keycloak:url"];
                options.AdminUserName = configuration["Keycloak:adminUsername"];
                options.AdminPassword = configuration["Keycloak:adminPassword"];
                options.RealmName = configuration["Keycloak:realmName"];
            }
        );
    }
}