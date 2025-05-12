using System;

namespace Walsun.Erp.BasketService.Services
{
    public interface IHasAnonymousId
    {
        Guid? AnonymousId { get; }
    }
}
