﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Volo.Abp;

namespace Walsun.Erp.DbMigrator;

public class DbMigratorHostedService : IHostedService
{
    private readonly IHostApplicationLifetime _hostApplicationLifetime;
    private readonly IConfiguration _configuration;

    public DbMigratorHostedService(
        IHostApplicationLifetime hostApplicationLifetime,
        IConfiguration configuration)
    {
        _hostApplicationLifetime = hostApplicationLifetime;
        _configuration = configuration;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using (var application = AbpApplicationFactory.Create<WalsunErpDbMigratorModule>(options =>
               {
                   options.Services.ReplaceConfiguration(_configuration);
                   options.UseAutofac();
                   options.Services.AddLogging(c => c.AddSerilog());
               }))
        {
            application.Initialize();

            await application
                .ServiceProvider
                .GetRequiredService<MigrationService>()
                .MigrateAsync(cancellationToken);

            application.Shutdown();

            _hostApplicationLifetime.StopApplication();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}