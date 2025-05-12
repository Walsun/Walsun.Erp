using Walsun.Erp.AdministrationService.EntityFrameworkCore;
using Walsun.Erp.Shared.Hosting.AspNetCore;
using Medallion.Threading;
using Medallion.Threading.Redis;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using Volo.Abp.AspNetCore.Authentication.JwtBearer;
using Volo.Abp.AspNetCore.Authentication.JwtBearer.DynamicClaims;
using Volo.Abp.BackgroundJobs.RabbitMQ;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.DistributedLocking;
using Volo.Abp.EventBus.RabbitMq;
using Volo.Abp.Modularity;

namespace Walsun.Erp.Shared.Hosting.Microservices;

[DependsOn(
    typeof(WalsunErpSharedHostingAspNetCoreModule),
    typeof(AbpBackgroundJobsRabbitMqModule),
    typeof(AbpAspNetCoreAuthenticationJwtBearerModule),
    typeof(AbpEventBusRabbitMqModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(AbpDistributedLockingModule)
)]
public class WalsunErpSharedHostingMicroservicesModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
        var configuration = context.Services.GetConfiguration();

        Configure<AbpDistributedCacheOptions>(options =>
        {
            options.KeyPrefix = "WalsunErp:";
        });

        var redis = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]!);
        context.Services
            .AddDataProtection()
            .PersistKeysToStackExchangeRedis(redis, "WalsunErp-Protection-Keys");
            
        context.Services.AddSingleton<IDistributedLockProvider>(sp =>
        {
            var connection = ConnectionMultiplexer.Connect(configuration["Redis:Configuration"]!);
            return new RedisDistributedSynchronizationProvider(connection.GetDatabase());
        });
    }
}