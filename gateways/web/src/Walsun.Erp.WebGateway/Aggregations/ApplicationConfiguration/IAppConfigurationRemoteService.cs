using Walsun.Erp.WebGateway.Aggregations.Base;
using Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations;

namespace Walsun.Erp.WebGateway.Aggregations.ApplicationConfiguration;

public interface IAppConfigurationRemoteService : IAggregateRemoteService<ApplicationConfigurationDto>;