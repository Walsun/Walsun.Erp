﻿using System;
using System.Threading.Tasks;
using Walsun.Erp.BasketService.Services;
using Walsun.Erp.Shared.Hosting.AspNetCore;
using Microsoft.AspNetCore.Http;
using Volo.Abp.DependencyInjection;

namespace Walsun.Erp.PublicWeb.ServiceProviders
{
    public class UserBasketProvider : ITransientDependency
    {
        private HttpContext HttpContext => _httpContextAccessor.HttpContext;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IBasketAppService _basketAppService;

        public UserBasketProvider(
            IHttpContextAccessor httpContextAccessor,
            IBasketAppService basketAppService)
        {
            _httpContextAccessor = httpContextAccessor;
            _basketAppService = basketAppService;
        }

        public virtual async Task<BasketDto> GetBasketAsync()
        {
            var anonymousUserId = await GetAnonymousUserId();

            return await _basketAppService.GetAsync(Guid.Parse(anonymousUserId));
        }

        // Get anonymous user id from cookie
        private async Task<string> GetAnonymousUserId()
        {
            HttpContext.Request.Cookies.TryGetValue(ErpConstants.AnonymousUserClaimName, out string anonymousUserId);
            // Generate guid for anonymous user id and set to cookie for 14 days
            if (string.IsNullOrEmpty(anonymousUserId))
            {
                anonymousUserId = Guid.NewGuid().ToString();
                HttpContext.Response.Cookies.Append(ErpConstants.AnonymousUserClaimName, anonymousUserId,
                    new CookieOptions
                    {
                        SameSite = SameSiteMode.Lax,
                        Expires = DateTimeOffset.UtcNow.AddDays(14)
                    });
            }

            return await Task.FromResult(anonymousUserId);
        }
    }
}