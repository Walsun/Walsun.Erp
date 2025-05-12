param ($version='latest')

az acr login --name volosoft

docker tag walsunerp/app-web:$version volosoft.azurecr.io/walsunerp/app-web:$version
docker push volosoft.azurecr.io/walsunerp/app-web:$version
docker tag volosoft.azurecr.io/walsunerp/app-web:$version volosoft.azurecr.io/walsunerp/dbmigrator:latest

docker tag walsunerp/app-authserver:$version volosoft.azurecr.io/walsunerp/app-authserver:$version
docker push volosoft.azurecr.io/walsunerp/app-authserver:$version
docker tag volosoft.azurecr.io/walsunerp/app-authserver:$version volosoft.azurecr.io/walsunerp/app-authserver:latest

docker tag walsunerp/app-publicweb:$version volosoft.azurecr.io/walsunerp/app-publicweb:$version
docker push volosoft.azurecr.io/walsunerp/app-publicweb:$version
docker tag volosoft.azurecr.io/walsunerp/app-publicweb:$version volosoft.azurecr.io/walsunerp/app-publicweb:latest

docker tag walsunerp/gateway-web:$version volosoft.azurecr.io/walsunerp/gateway-web:$version
docker push volosoft.azurecr.io/walsunerp/gateway-web:$version
docker tag volosoft.azurecr.io/walsunerp/gateway-web:$version volosoft.azurecr.io/walsunerp/gateway-web:latest

docker tag walsunerp/gateway-web-public:$version volosoft.azurecr.io/walsunerp/gateway-web-public:$version
docker push volosoft.azurecr.io/walsunerp/gateway-web-public:$version
docker tag volosoft.azurecr.io/walsunerp/gateway-web-public:$version volosoft.azurecr.io/walsunerp/gateway-web-public:latest

docker tag walsunerp/service-identity:$version volosoft.azurecr.io/walsunerp/service-identity:$version
docker push volosoft.azurecr.io/walsunerp/service-identity:$version
docker tag volosoft.azurecr.io/walsunerp/service-identity:$version volosoft.azurecr.io/walsunerp/service-identity:latest

docker tag walsunerp/service-administration:$version volosoft.azurecr.io/walsunerp/service-administration:$version
docker push volosoft.azurecr.io/walsunerp/service-administration:$version
docker tag volosoft.azurecr.io/walsunerp/service-administration:$version volosoft.azurecr.io/walsunerp/service-administration:latest

docker tag walsunerp/service-catalog:$version volosoft.azurecr.io/walsunerp/service-catalog:$version
docker push volosoft.azurecr.io/walsunerp/service-catalog:$version
docker tag volosoft.azurecr.io/walsunerp/service-catalog:$version volosoft.azurecr.io/walsunerp/service-catalog:latest

docker tag walsunerp/service-basket:$version volosoft.azurecr.io/walsunerp/service-basket:$version
docker push volosoft.azurecr.io/walsunerp/service-basket:$version
docker tag volosoft.azurecr.io/walsunerp/service-basket:$version volosoft.azurecr.io/walsunerp/service-basket:latest

docker tag walsunerp/service-payment:$version volosoft.azurecr.io/walsunerp/service-payment:$version
docker push volosoft.azurecr.io/walsunerp/service-payment:$version
docker tag volosoft.azurecr.io/walsunerp/service-payment:$version volosoft.azurecr.io/walsunerp/service-payment:latest

docker tag walsunerp/service-ordering:$version volosoft.azurecr.io/walsunerp/service-ordering:$version
docker push volosoft.azurecr.io/walsunerp/service-ordering:$version
docker tag volosoft.azurecr.io/walsunerp/service-ordering:$version volosoft.azurecr.io/walsunerp/service-ordering:latest

docker tag walsunerp/service-cmskit:$version volosoft.azurecr.io/walsunerp/service-cmskit:$version
docker push volosoft.azurecr.io/walsunerp/service-cmskit:$version
docker tag volosoft.azurecr.io/walsunerp/service-cmskit:$version volosoft.azurecr.io/walsunerp/service-cmskit:latest



