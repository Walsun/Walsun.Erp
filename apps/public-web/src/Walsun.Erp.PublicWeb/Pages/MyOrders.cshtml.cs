﻿using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Walsun.Erp.PublicWeb.Pages;

public class MyOrdersModel : AbpPageModel
{
    public string OrderFilter { get; set; }

    public Task OnGet(string filter)
    {
        OrderFilter = filter;
        return Task.CompletedTask;
    }
}