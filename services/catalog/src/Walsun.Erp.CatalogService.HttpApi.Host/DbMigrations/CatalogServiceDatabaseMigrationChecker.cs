﻿using Walsun.Erp.CatalogService.MongoDB;
using System;
using Walsun.Erp.Shared.Hosting.Microservices.DbMigrations.MongoDb;
using Volo.Abp.Data;
using Volo.Abp.DistributedLocking;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

namespace Walsun.Erp.CatalogService.DbMigrations;

public class CatalogServiceDatabaseMigrationChecker : PendingMongoDbMigrationsChecker<CatalogServiceMongoDbContext>
{
    public CatalogServiceDatabaseMigrationChecker(
        IUnitOfWorkManager unitOfWorkManager,
        IServiceProvider serviceProvider,
        ICurrentTenant currentTenant,
        IDataSeeder dataSeeder,
        IAbpDistributedLock distributedLockProvider)
        : base(
            unitOfWorkManager,
            serviceProvider,
            currentTenant,
            dataSeeder,
            distributedLockProvider,
            CatalogServiceDbProperties.ConnectionStringName)
    {
    }
}