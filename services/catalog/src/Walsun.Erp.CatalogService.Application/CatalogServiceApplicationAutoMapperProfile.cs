using AutoMapper;
using Walsun.Erp.CatalogService.Grpc;
using Walsun.Erp.CatalogService.Products;

namespace Walsun.Erp.CatalogService
{
    public class CatalogServiceApplicationAutoMapperProfile : Profile
    {
        public CatalogServiceApplicationAutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Product, ProductResponse>();
        }
    }
}
