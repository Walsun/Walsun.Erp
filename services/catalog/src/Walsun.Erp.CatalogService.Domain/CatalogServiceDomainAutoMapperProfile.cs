using AutoMapper;
using Walsun.Erp.CatalogService.Products;

namespace Walsun.Erp.CatalogService
{
    public class CatalogServiceDomainAutoMapperProfile : Profile
    {
        public CatalogServiceDomainAutoMapperProfile()
        {
            CreateMap<Product, ProductEto>();
        }
    }
}
