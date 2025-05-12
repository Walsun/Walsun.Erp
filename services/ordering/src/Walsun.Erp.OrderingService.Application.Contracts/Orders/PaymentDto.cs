using Volo.Abp.Application.Dtos;

namespace Walsun.Erp.OrderingService.Orders;

public class PaymentDto : EntityDto
{
    public decimal RateOfPaymentMethod { get; set; }
    public string PaymentMethod { get; set; }
}