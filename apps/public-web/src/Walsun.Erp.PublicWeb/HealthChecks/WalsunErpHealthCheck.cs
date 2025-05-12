using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations;
using Volo.Abp.DependencyInjection;

namespace Walsun.Erp.PublicWeb.HealthChecks;

public class WalsunErpHealthCheck : IHealthCheck, ITransientDependency
{
    protected readonly IAbpApplicationConfigurationAppService ApplicationConfigurationAppService;

    public WalsunErpHealthCheck(IAbpApplicationConfigurationAppService applicationConfigurationAppService)
    {
        ApplicationConfigurationAppService = applicationConfigurationAppService;
    }

    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        try
        {
            await ApplicationConfigurationAppService.GetAsync(new ApplicationConfigurationRequestOptions()
            {
                IncludeLocalizationResources = false
            });

            return HealthCheckResult.Healthy($"Could connect to database and get record.");
        }
        catch (Exception e)
        {
            return HealthCheckResult.Unhealthy($"Error when trying to get database record. ", e);
        }
    }
}
