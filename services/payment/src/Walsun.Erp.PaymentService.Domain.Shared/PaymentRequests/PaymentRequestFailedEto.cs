﻿using System;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus;

namespace Walsun.Erp.PaymentService.PaymentRequests
{
    [EventName("Walsun.Erp.Payment.Completed")]
    public class PaymentRequestFailedEto : EtoBase, IHasExtraProperties
    {
        public Guid PaymentRequestId { get; set; }
        
        public string OrderId { get; set; }
        public int OrderNo { get; set; }
        public string FailReason { get; set; }
        public ExtraPropertyDictionary ExtraProperties { get; set; }
    }
}