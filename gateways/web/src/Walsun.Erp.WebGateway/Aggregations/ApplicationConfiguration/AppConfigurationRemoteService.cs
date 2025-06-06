﻿using Walsun.Erp.WebGateway.Aggregations.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Json;

namespace Walsun.Erp.WebGateway.Aggregations.ApplicationConfiguration;

public class AppConfigurationRemoteService(
    IHttpContextAccessor httpContextAccessor,
    IJsonSerializer jsonSerializer,
    ILogger<AggregateRemoteServiceBase<ApplicationConfigurationDto>> logger)
    : AggregateRemoteServiceBase<ApplicationConfigurationDto>(httpContextAccessor, jsonSerializer, logger),
        IAppConfigurationRemoteService, ITransientDependency;