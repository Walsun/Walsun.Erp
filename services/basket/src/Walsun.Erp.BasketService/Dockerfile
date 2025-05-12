FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# It's important to keep lines from here down to "COPY . ." identical in all Dockerfiles
# to take advantage of Docker's build cache, to speed up local container builds
COPY "Walsun.Erp.sln" "Walsun.Erp.sln"

# Applications
COPY "apps/public-web/src/Walsun.Erp.PublicWeb/Walsun.Erp.PublicWeb.csproj" "apps/public-web/src/Walsun.Erp.PublicWeb/Walsun.Erp.PublicWeb.csproj"

# Shared
COPY "shared/Walsun.Erp.Shared.Hosting/Walsun.Erp.Shared.Hosting.csproj" "shared/Walsun.Erp.Shared.Hosting/Walsun.Erp.Shared.Hosting.csproj"
COPY "shared/Walsun.Erp.Shared.Hosting.AspNetCore/Walsun.Erp.Shared.Hosting.AspNetCore.csproj" "shared/Walsun.Erp.Shared.Hosting.AspNetCore/Walsun.Erp.Shared.Hosting.AspNetCore.csproj"
COPY "shared/Walsun.Erp.Shared.Hosting.Gateways/Walsun.Erp.Shared.Hosting.Gateways.csproj" "shared/Walsun.Erp.Shared.Hosting.Gateways/Walsun.Erp.Shared.Hosting.Gateways.csproj"
COPY "shared/Walsun.Erp.Shared.Hosting.Microservices/Walsun.Erp.Shared.Hosting.Microservices.csproj" "shared/Walsun.Erp.Shared.Hosting.Microservices/Walsun.Erp.Shared.Hosting.Microservices.csproj"
COPY "shared/Walsun.Erp.Shared.Localization/Walsun.Erp.Shared.Localization.csproj" "shared/Walsun.Erp.Shared.Localization/Walsun.Erp.Shared.Localization.csproj"

# Microservices
COPY "services/administration/src/Walsun.Erp.AdministrationService.HttpApi.Host/Walsun.Erp.AdministrationService.HttpApi.Host.csproj" "services/administration/src/Walsun.Erp.AdministrationService.HttpApi.Host/Walsun.Erp.AdministrationService.HttpApi.Host.csproj"
COPY "services/identity/src/Walsun.Erp.IdentityService.HttpApi.Host/Walsun.Erp.IdentityService.HttpApi.Host.csproj" "services/identity/src/Walsun.Erp.IdentityService.HttpApi.Host/Walsun.Erp.IdentityService.HttpApi.Host.csproj"
COPY "services/basket/src/Walsun.Erp.BasketService/Walsun.Erp.BasketService.csproj" "services/basket/src/Walsun.Erp.BasketService/Walsun.Erp.BasketService.csproj"
COPY "services/ordering/src/Walsun.Erp.OrderingService.HttpApi.Host/Walsun.Erp.OrderingService.HttpApi.Host.csproj" "services/ordering/src/Walsun.Erp.OrderingService.HttpApi.Host/Walsun.Erp.OrderingService.HttpApi.Host.csproj"
COPY "services/catalog/src/Walsun.Erp.CatalogService.HttpApi.Host/Walsun.Erp.CatalogService.HttpApi.Host.csproj" "services/catalog/src/Walsun.Erp.CatalogService.HttpApi.Host/Walsun.Erp.CatalogService.HttpApi.Host.csproj"
COPY "services/payment/src/Walsun.Erp.PaymentService.HttpApi.Host/Walsun.Erp.PaymentService.HttpApi.Host.csproj" "services/payment/src/Walsun.Erp.PaymentService.HttpApi.Host/Walsun.Erp.PaymentService.HttpApi.Host.csproj"
COPY "services/cmskit/src/Walsun.Erp.CmskitService.HttpApi.Host/Walsun.Erp.CmskitService.HttpApi.Host.csproj" "services/cmskit/src/Walsun.Erp.CmskitService.HttpApi.Host/Walsun.Erp.CmskitService.HttpApi.Host.csproj"

# Gateways
COPY "gateways/web/src/Walsun.Erp.WebGateway/Walsun.Erp.WebGateway.csproj" "gateways/web/src/Walsun.Erp.WebGateway/Walsun.Erp.WebGateway.csproj"
COPY "gateways/web-public/src/Walsun.Erp.WebPublicGateway/Walsun.Erp.WebPublicGateway.csproj" "gateways/web-public/src/Walsun.Erp.WebPublicGateway/Walsun.Erp.WebPublicGateway.csproj"

COPY "NuGet.Config" "NuGet.Config"

RUN dotnet restore "Walsun.Erp.sln"
COPY . .

WORKDIR "/src/services/basket/src/Walsun.Erp.BasketService"
RUN dotnet publish -c Release -o /app 
# RUN dotnet publish --no-restore -c Release -o /app 

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Walsun.Erp.BasketService.dll"]