﻿using Walsun.Erp.CatalogService.Products;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Walsun.Erp.CatalogService.MongoDB
{
    [ConnectionStringName(CatalogServiceDbProperties.ConnectionStringName)]
    public class CatalogServiceMongoDbContext : AbpMongoDbContext, ICatalogServiceMongoDbContext
    {
        public IMongoCollection<Product> Products => Collection<Product>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureCatalogService();
        }
    }
}