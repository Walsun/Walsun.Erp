﻿using System.Threading.Tasks;
using Walsun.Erp.OrderingService.Orders;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Walsun.Erp.PublicWeb.Pages;

public class OrderReceivedModel : AbpPageModel
{
    private readonly IOrderAppService _orderAppService;
    [BindProperty(SupportsGet = true)] public int OrderNo { get; set; }
    public OrderDto ReceivedOrder { get; set; }

    public OrderReceivedModel(IOrderAppService orderAppService)
    {
        _orderAppService = orderAppService;
    }

    public async Task OnGet(int orderNo)
    {
        ReceivedOrder = await _orderAppService.GetByOrderNoAsync(orderNo);
    }
}