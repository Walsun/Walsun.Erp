using System;
using Volo.Abp.Domain.Repositories;

namespace Walsun.Erp.PaymentService.PaymentRequests
{
    public interface IPaymentRequestRepository : IBasicRepository<PaymentRequest, Guid>
    {
    }
}
