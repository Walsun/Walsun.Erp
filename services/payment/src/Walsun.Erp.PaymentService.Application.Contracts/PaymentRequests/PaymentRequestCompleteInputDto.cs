﻿using System;

namespace Walsun.Erp.PaymentService.PaymentRequests;

[Serializable]
public class PaymentRequestCompleteInputDto
{
    public string Token { get; set; }
    public int PaymentTypeId { get; set; }
}