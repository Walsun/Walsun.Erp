using AutoMapper;
using Walsun.Erp.OrderingService.OrderItems;
using Walsun.Erp.OrderingService.Orders;
using Volo.Abp.AutoMapper;

namespace Walsun.Erp.OrderingService
{
    public class OrderingServiceApplicationAutoMapperProfile : Profile
    {
        public OrderingServiceApplicationAutoMapperProfile()
        {
            CreateMap<Address, OrderAddressDto>();
            CreateMap<Buyer, BuyerDto>();

            CreateMap<OrderItem, OrderItemDto>();
            CreateMap<OrderItem, TopSellingDto>();

            CreateMap<Order, OrderDto>()
                .Ignore(q => q.Address)
                .Ignore(q => q.Items)
                .Ignore(q => q.Buyer);
        }
    }
}