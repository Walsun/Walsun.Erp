using System.Collections.Generic;
using Walsun.Erp.WebGateway.Aggregations.Base;

namespace Walsun.Erp.WebGateway.Aggregations.ApplicationConfiguration;

public class AppConfigurationRequest : IRequestInput
{
    public Dictionary<string, string> Endpoints { get; } = new();
}