﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Walsun.Erp.PaymentService.PaymentMethods;

public interface IPaymentMethodAppService : IApplicationService
{
    Task<List<PaymentMethodDto>> GetListAsync();
}
