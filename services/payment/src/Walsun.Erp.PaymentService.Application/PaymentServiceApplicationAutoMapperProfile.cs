using AutoMapper;
using Walsun.Erp.PaymentService.PaymentRequests;
using Volo.Abp.AutoMapper;

namespace Walsun.Erp.PaymentService
{
    public class PaymentServiceApplicationAutoMapperProfile : Profile
    {
        public PaymentServiceApplicationAutoMapperProfile()
        {
            CreateMap<PaymentRequest, PaymentRequestDto>();
            CreateMap<PaymentRequestProduct, PaymentRequestProductDto>();

            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
        }
    }
}