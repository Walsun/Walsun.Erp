export version="latest"

az acr login --name volocr

docker tag walsunerp/app-web:"${version}" ghcr.io/volosoft/walsunerp/app-web:"${version}"
docker push ghcr.io/volosoft/walsunerp/app-web:"${version}"

docker tag walsunerp/app-authserver:"${version}" ghcr.io/volosoft/walsunerp/app-authserver:"${version}"
docker push ghcr.io/volosoft/walsunerp/app-authserver:"${version}"

docker tag walsunerp/app-publicweb:"${version}" ghcr.io/volosoft/walsunerp/app-publicweb:"${version}"
docker push ghcr.io/volosoft/walsunerp/app-publicweb:"${version}"

docker tag walsunerp/gateway-web:"${version}" ghcr.io/volosoft/walsunerp/gateway-web:"${version}"
docker push ghcr.io/volosoft/walsunerp/gateway-web:"${version}"

docker tag walsunerp/gateway-web-public:"${version}" ghcr.io/volosoft/walsunerp/gateway-web-public:"${version}"
docker push ghcr.io/volosoft/walsunerp/gateway-web-public:"${version}"

docker tag walsunerp/service-identity:"${version}" ghcr.io/volosoft/walsunerp/service-identity:"${version}"
docker push ghcr.io/volosoft/walsunerp/service-identity:"${version}"

docker tag walsunerp/service-administration:"${version}" ghcr.io/volosoft/walsunerp/service-administration:"${version}"
docker push ghcr.io/volosoft/walsunerp/service-administration:"${version}"

docker tag walsunerp/service-basket:"${version}" ghcr.io/volosoft/walsunerp/service-basket:"${version}"
docker push ghcr.io/volosoft/walsunerp/service-basket:"${version}"

docker tag walsunerp/service-catalog:"${version}" ghcr.io/volosoft/walsunerp/service-catalog:"${version}"
docker push ghcr.io/volosoft/walsunerp/service-catalog:"${version}"

docker tag walsunerp/service-ordering:"${version}" ghcr.io/volosoft/walsunerp/service-ordering:"${version}"
docker push ghcr.io/volosoft/walsunerp/service-ordering:"${version}"

docker tag walsunerp/service-cmskit:"${version}" ghcr.io/volosoft/walsunerp/service-cmskit:"${version}"
docker push ghcr.io/volosoft/walsunerp/service-cmskit:"${version}"

docker tag walsunerp/service-payment:"${version}" ghcr.io/volosoft/walsunerp/service-payment:"${version}"
docker push ghcr.io/volosoft/walsunerp/service-payment:"${version}"