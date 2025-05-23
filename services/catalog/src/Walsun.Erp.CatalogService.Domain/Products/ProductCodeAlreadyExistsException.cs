﻿using Volo.Abp;

namespace Walsun.Erp.CatalogService.Products
{
    public class ProductCodeAlreadyExistsException : BusinessException
    {
        public ProductCodeAlreadyExistsException(string productCode)
            : base("CatalogService:000001", $"A product with code {productCode} has already exists!")
        {
            WithData("productCode", productCode);
        }
    }
}