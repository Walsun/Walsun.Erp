﻿using Walsun.Erp.OrderingService.OrderItems;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Walsun.Erp.OrderingService.Orders;

public class DashboardDto: EntityDto
{
    public List<TopSellingDto> TopSellings { get; set; }
    public List<PaymentDto> Payments { get; set; }
    public List<OrderStatusDto> OrderStatusDto { get; set; }
}