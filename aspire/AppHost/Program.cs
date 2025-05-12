using Walsun.Erp.AppHost;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddForwardedHeaders();

var profile = "http";

// Microservices
var administrationService =
    builder.AddProject<Projects.Walsun_Erp_AdministrationService_HttpApi_Host>("administrationService", profile);
var identityService = builder.AddProject<Projects.Walsun_Erp_IdentityService_HttpApi_Host>("identityService", profile);
var catalogService = builder.AddProject<Projects.Walsun_Erp_CatalogService_HttpApi_Host>("catalogService")
    .WithHttpEndpoint(name: "http", port: 5054, isProxied: false)
    .WithEndpoint(
        endpointName: "grpc",
        callback: static endpoint =>
        {
            endpoint.Port = 8181;
            endpoint.UriScheme = "http";
            endpoint.Transport = "http2";
            endpoint.IsProxied = false;
        }
    );
var basketService = builder.AddProject<Projects.Walsun_Erp_BasketService>("basketService", profile)
    .WithReference(catalogService);
var cmsKitService = builder.AddProject<Projects.Walsun_Erp_CmskitService_HttpApi_Host>("cmsKitService", profile);
var orderingService = builder.AddProject<Projects.Walsun_Erp_OrderingService_HttpApi_Host>("orderingService", profile);
var paymentService = builder.AddProject<Projects.Walsun_Erp_PaymentService_HttpApi_Host>("paymentService", profile);

// Gateways
var webGateway = builder.AddProject<Projects.Walsun_Erp_WebGateway>("webGateway");
var webPublicGateway = builder.AddProject<Projects.Walsun_Erp_WebPublicGateway>("webPublicGateway")
    .WithReference(administrationService)
    .WithReference(identityService)
    .WithReference(catalogService)
    .WithReference(basketService)
    .WithReference(cmsKitService)
    .WithReference(orderingService)
    .WithReference(paymentService);

// Apps
var publicWebApp = builder.AddProject<Projects.Walsun_Erp_PublicWeb>("public-web", "https")
    .WithExternalHttpEndpoints()
    .WithReference(catalogService)
    .WithReference(webPublicGateway);

builder.Build().Run();