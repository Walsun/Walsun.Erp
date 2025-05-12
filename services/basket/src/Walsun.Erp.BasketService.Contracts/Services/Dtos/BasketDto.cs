using System.Collections.Generic;

namespace Walsun.Erp.BasketService.Services;

public class BasketDto
{
    public float TotalPrice { get; set; }
    public List<BasketItemDto> Items { get; set; }

    public BasketDto()
    {
        Items = new List<BasketItemDto>();
    }
}