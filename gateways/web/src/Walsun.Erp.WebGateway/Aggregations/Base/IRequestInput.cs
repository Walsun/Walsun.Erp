using System.Collections.Generic;

namespace Walsun.Erp.WebGateway.Aggregations.Base;

public interface IRequestInput
{
    Dictionary<string, string> Endpoints { get; }
}