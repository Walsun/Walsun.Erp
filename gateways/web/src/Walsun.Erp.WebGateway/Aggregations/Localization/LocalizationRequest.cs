using System.Collections.Generic;
using Walsun.Erp.WebGateway.Aggregations.Base;

namespace Walsun.Erp.WebGateway.Aggregations.Localization;

public class LocalizationRequest : IRequestInput
{
    public Dictionary<string, string> Endpoints { get; } = new();
    public string CultureName { get; set; }

    public LocalizationRequest(string cultureName)
    {
        CultureName = cultureName;
    }
}