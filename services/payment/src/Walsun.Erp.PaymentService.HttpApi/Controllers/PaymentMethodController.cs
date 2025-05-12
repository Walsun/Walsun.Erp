using Walsun.Erp.PaymentService.PaymentMethods;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;

namespace Walsun.Erp.PaymentService.Controllers;

[RemoteService(Name = PaymentServiceRemoteServiceConsts.RemoteServiceName)]
[Area("payment")]
[Route("api/payment/methods")]
public class PaymentMethodController : PaymentServiceController, IPaymentMethodAppService
{
    protected IPaymentMethodAppService PaymentMethodAppService { get; }

    public PaymentMethodController(IPaymentMethodAppService paymentMethodAppService)
    {
        PaymentMethodAppService = paymentMethodAppService;
    }

    [HttpGet]
    public Task<List<PaymentMethodDto>> GetListAsync()
    {
        return PaymentMethodAppService.GetListAsync();
    }
}
