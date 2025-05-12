using Walsun.Erp.WebGateway.Aggregations.Base;
using Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations;

namespace Walsun.Erp.WebGateway.Aggregations.Localization;

public interface ILocalizationRemoteService : IAggregateRemoteService<ApplicationLocalizationDto>;