﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Walsun.Erp.CatalogService.MongoDB
{
    [ConnectionStringName(CatalogServiceDbProperties.ConnectionStringName)]
    public interface ICatalogServiceMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
