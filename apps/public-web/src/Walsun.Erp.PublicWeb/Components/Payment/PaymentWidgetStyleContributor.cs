using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Walsun.Erp.PublicWeb.Components.Payment;

public class PaymentWidgetStyleContributor: BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/components/payment/payment-widget.css");
    }
}