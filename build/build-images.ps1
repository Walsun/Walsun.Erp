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

Write-Host "===== BUILDING APPLICATIONS =====" -ForegroundColor Yellow

### Angular WEB App
Write-Host "*** BUILDING ANGULAR WEB APPLICATION 1/$total ***" -ForegroundColor Green
Set-Location $webAppFolder
docker build -f "$webAppFolder/Dockerfile" -t walsunerp/app-web:$version .

### PUBLIC-WEB
Write-Host "**************** BUILDING WEB-PUBLIC 2/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$publicWebFolder/Dockerfile" -t walsunerp/app-publicweb:$version .

Write-Host "===== BUILDING GATEWAYS =====" -ForegroundColor Yellow 

### WEB-GATEWAY
Write-Host "**************** BUILDING WEB-GATEWAY 3/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$webGatewayFolder/Dockerfile" -t walsunerp/gateway-web:$version .

### PUBLICWEB-GATEWAY
Write-Host "**************** BUILDING WEB-PUBLIC-GATEWAY 4/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$webPublicGatewayFolder/Dockerfile" -t walsunerp/gateway-web-public:$version .

Write-Host "===== BUILDING MICROSERVICES =====" -ForegroundColor Yellow

### IDENTITY-SERVICE
Write-Host "**************** BUILDING IDENTITY-SERVICE 5/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$identityServiceFolder/Dockerfile" -t walsunerp/service-identity:$version .

### ADMINISTRATION-SERVICE
Write-Host "**************** BUILDING ADMINISTRATION-SERVICE 6/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$administrationServiceFolder/Dockerfile" -t walsunerp/service-administration:$version .

### BASKET-SERVICE
Write-Host "**************** BUILDING BASKET-SERVICE 7/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$basketServiceFolder/Dockerfile" -t walsunerp/service-basket:$version .

### CATALOG-SERVICE
Write-Host "**************** BUILDING CATALOG-SERVICE 8/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$catalogServiceFolder/Dockerfile" -t walsunerp/service-catalog:$version .

### PAYMENT-SERVICE
Write-Host "**************** BUILDING PAYMENT-SERVICE 9/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$paymentServiceFolder/Dockerfile" -t walsunerp/service-payment:$version .

### ORDERING-SERVICE
Write-Host "**************** BUILDING ORDERING-SERVICE 10/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$orderingServiceFolder/Dockerfile" -t walsunerp/service-ordering:$version .

### CMSKIT-SERVICE
Write-Host "**************** BUILDING CMSKIT-SERVICE 11/$total ****************" -ForegroundColor Green
Set-Location $slnFolder
docker build -f "$cmskitServiceFolder/Dockerfile" -t walsunerp/service-cmskit:$version .

### ALL COMPLETED
Write-Host "ALL COMPLETED" -ForegroundColor Green
Set-Location $currentFolder