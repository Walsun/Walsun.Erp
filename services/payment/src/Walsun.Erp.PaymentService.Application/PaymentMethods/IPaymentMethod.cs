using System.Threading.Tasks;
using Walsun.Erp.PaymentService.PaymentRequests;
using Volo.Abp.DependencyInjection;

namespace Walsun.Erp.PaymentService.PaymentMethods;

public interface IPaymentMethod : ITransientDependency
{
    string Name { get; }

    public Task<PaymentRequestStartResultDto> StartAsync(PaymentRequest paymentRequest, PaymentRequestStartDto input);

    public Task<PaymentRequest> CompleteAsync(IPaymentRequestRepository paymentRequestRepository, string token);

    public Task HandleWebhookAsync(string payload);
}