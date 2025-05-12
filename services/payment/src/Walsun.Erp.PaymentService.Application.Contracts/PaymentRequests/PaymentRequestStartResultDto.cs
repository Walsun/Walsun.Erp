using System;

namespace Walsun.Erp.PaymentService.PaymentRequests;

[Serializable]
public class PaymentRequestStartResultDto
{
    public string CheckoutLink { get; set; }
}