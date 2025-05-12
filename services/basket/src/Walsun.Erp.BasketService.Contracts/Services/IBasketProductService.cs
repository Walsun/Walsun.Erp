using System;
using System.Threading.Tasks;
using Walsun.Erp.CatalogService.Products;
using JetBrains.Annotations;

namespace Walsun.Erp.BasketService.Services;

public interface IBasketProductService
{
    [ItemNotNull]
    Task<ProductDto> GetAsync(Guid productId);
}