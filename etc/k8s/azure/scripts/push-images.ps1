param ($version='1.0.0')

az acr login --name volocr

docker tag walsunerp/app-web:$version volocr.azurecr.io/walsunerp/app-web:$version
docker push volocr.azurecr.io/walsunerp/app-web:$version

docker tag walsunerp/app-authserver:$version volocr.azurecr.io/walsunerp/app-authserver:$version
docker push volocr.azurecr.io/walsunerp/app-authserver:$version

docker tag walsunerp/app-publicweb:$version volocr.azurecr.io/walsunerp/app-publicweb:$version
docker push volocr.azurecr.io/walsunerp/app-publicweb:$version

docker tag walsunerp/gateway-web:$version volocr.azurecr.io/walsunerp/gateway-web:$version
docker push volocr.azurecr.io/walsunerp/gateway-web:$version

docker tag walsunerp/gateway-web-public:$version volocr.azurecr.io/walsunerp/gateway-web-public:$version
docker push volocr.azurecr.io/walsunerp/gateway-web-public:$version

docker tag walsunerp/service-identity:$version volocr.azurecr.io/walsunerp/service-identity:$version
docker push volocr.azurecr.io/walsunerp/service-identity:$version

docker tag walsunerp/service-administration:$version volocr.azurecr.io/walsunerp/service-administration:$version
docker push volocr.azurecr.io/walsunerp/service-administration:$version

docker tag walsunerp/service-basket:$version volocr.azurecr.io/walsunerp/service-basket:$version
docker push volocr.azurecr.io/walsunerp/service-basket:$version

docker tag walsunerp/service-catalog:$version volocr.azurecr.io/walsunerp/service-catalog:$version
docker push volocr.azurecr.io/walsunerp/service-catalog:$version

docker tag walsunerp/service-ordering:$version volocr.azurecr.io/walsunerp/service-ordering:$version
docker push volocr.azurecr.io/walsunerp/service-ordering:$version

docker tag walsunerp/service-cmskit:$version volocr.azurecr.io/walsunerp/service-cmskit:$version
docker push volocr.azurecr.io/walsunerp/service-cmskit:$version

docker tag walsunerp/service-payment:$version volocr.azurecr.io/walsunerp/service-payment:$version
docker push volocr.azurecr.io/walsunerp/service-payment:$version