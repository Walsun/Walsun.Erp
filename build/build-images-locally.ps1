param ($version='latest')

$currentFolder = $PSScriptRoot
$slnFolder = Join-Path $currentFolder "../"
# Apps
$webAppFolder = Join-Path $slnFolder "apps/angular"
$publicWebFolder = Join-Path $slnFolder "apps/public-web/src/Walsun.Erp.PublicWeb"
# Gateways
$webGatewayFolder = Join-Path $slnFolder "gateways/web/src/Walsun.Erp.WebGateway"
$webPublicGatewayFolder = Join-Path $slnFolder "gateways/web-public/src/Walsun.Erp.WebPublicGateway"
# Microservices
$identityServiceFolder = Join-Path $slnFolder "services/identity/src/Walsun.Erp.IdentityService.HttpApi.Host"
$administrationServiceFolder = Join-Path $slnFolder "services/administration/src/Walsun.Erp.AdministrationService.HttpApi.Host"
$basketServiceFolder = Join-Path $slnFolder "services/basket/src/Walsun.Erp.BasketService"
$catalogServiceFolder = Join-Path $slnFolder "services/catalog/src/Walsun.Erp.CatalogService.HttpApi.Host"
$paymentServiceFolder = Join-Path $slnFolder "services/payment/src/Walsun.Erp.PaymentService.HttpApi.Host"
$orderingServiceFolder = Join-Path $slnFolder "services/ordering/src/Walsun.Erp.OrderingService.HttpApi.Host"
$cmskitServiceFolder = Join-Path $slnFolder "services/cmskit/src/Walsun.Erp.CmskitService.HttpApi.Host"

$total = 11

### Angular WEB App(WWW)
Write-Host "*** BUILDING WEB (WWW) 1/$total ****************" -ForegroundColor Green
Set-Location $webAppFolder
yarn
# ng build --prod
npm run build:prod
docker build -f Dockerfile.local -t walsunerp/app-web:$version .

### PUBLIC-WEB
Write-Host "*** BUILDING WEB-PUBLIC 2/$total ****************" -ForegroundColor Green
Set-Location $publicWebFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t walsunerp/app-publicweb:$version .

### WEB-GATEWAY
Write-Host "*** BUILDING WEB-GATEWAY 3/$total ****************" -ForegroundColor Green
Set-Location $webGatewayFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t walsunerp/gateway-web:$version .

### PUBLICWEB-GATEWAY
Write-Host "*** BUILDING WEB-PUBLIC-GATEWAY 4/$total ****************" -ForegroundColor Green
Set-Location $webPublicGatewayFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t walsunerp/gateway-web-public:$version .

### IDENTITY-SERVICE
Write-Host "*** BUILDING IDENTITY-SERVICE 5/$total ****************" -ForegroundColor Green
Set-Location $identityServiceFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t walsunerp/service-identity:$version .

### ADMINISTRATION-SERVICE
Write-Host "*** BUILDING ADMINISTRATION-SERVICE 6/$total ****************" -ForegroundColor Green
Set-Location $administrationServiceFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t walsunerp/service-administration:$version .

### BASKET-SERVICE
Write-Host "**************** BUILDING BASKET-SERVICE 7/$total ****************" -ForegroundColor Green
Set-Location $basketServiceFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t walsunerp/service-basket:$version .

### CATALOG-SERVICE
Write-Host "**************** BUILDING CATALOG-SERVICE 8/$total ****************" -ForegroundColor Green
Set-Location $catalogServiceFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t walsunerp/service-catalog:$version .

### PAYMENT-SERVICE
Write-Host "**************** BUILDING PAYMENT-SERVICE 9/$total ****************" -ForegroundColor Green
Set-Location $paymentServiceFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t walsunerp/service-payment:$version .

### ORDERING-SERVICE
Write-Host "**************** BUILDING ORDERING-SERVICE 10/$total ****************" -ForegroundColor Green
Set-Location $orderingServiceFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t walsunerp/service-ordering:$version .

### CMSKIT-SERVICE
Write-Host "**************** BUILDING CMSKIT-SERVICE 11/$total ****************" -ForegroundColor Green
Set-Location $cmskitServiceFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t walsunerp/service-cmskit:$version .

### ALL COMPLETED
Write-Host "ALL COMPLETED" -ForegroundColor Green
Set-Location $currentFolder