using AutoMapper;
using Walsun.Erp.CatalogService.Grpc;
using Walsun.Erp.CatalogService.Products;

namespace Walsun.Erp.BasketService;

public class BasketServiceApplicationAutoMapperProfile : Profile
{
    public BasketServiceApplicationAutoMapperProfile()
    {
        CreateMap<ProductEto, ProductDto>();
        CreateMap<ProductResponse, ProductDto>();
    }
}