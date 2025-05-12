using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus;

namespace Walsun.Erp.PaymentService.PaymentRequests;

[EventName("Walsun.Erp.Payment.Completed")]
public class PaymentCompletedEto : EtoBase
{
    public PaymentRequestDto PaymentRequest { get; set; }
}