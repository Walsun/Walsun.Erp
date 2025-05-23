#!/bin/bash

export IMAGE_TAG="latest"
export total=11
cd ../
export currentFolder=`pwd`
cd build/

echo "*** BUILDING WEB (WWW) 1/${total} ****************"
cd ${currentFolder}/apps/angular
docker build --force-rm -t "walsunerp/app-web:${IMAGE_TAG}" .


echo "*** BUILDING WEB-PUBLIC 2/$total ****************"
cd ${currentFolder}/apps/public-web/src/Walsun.Erp.PublicWeb
docker build --force-rm -t "walsunerp/app-publicweb:${IMAGE_TAG}" .


echo "*** BUILDING WEB-GATEWAY 3/$total ****************"
cd ${currentFolder}/gateways/web/src/Walsun.Erp.WebGateway
docker build --force-rm -t "walsunerp/gateway-web:${IMAGE_TAG}" .


echo "*** BUILDING WEB-PUBLIC-GATEWAY 4/$total ****************"
cd ${currentFolder}/gateways/web-public/src/Walsun.Erp.WebPublicGateway
docker build --force-rm -t "walsunerp/gateway-web-public:${IMAGE_TAG}" .


echo "*** BUILDING IDENTITY-SERVICE 5/$total ****************"
cd ${currentFolder}/services/identity/src/Walsun.Erp.IdentityService.HttpApi.Host
docker build --force-rm -t "walsunerp/service-identity:${IMAGE_TAG}" .


echo "*** BUILDING ADMINISTRATION-SERVICE 6/$total ****************"
cd ${currentFolder}/services/administration/src/Walsun.Erp.AdministrationService.HttpApi.Host
docker build --force-rm -t "walsunerp/service-administration:${IMAGE_TAG}" .


echo "**************** BUILDING BASKET-SERVICE 7/$total ****************"
cd ${currentFolder}/services/basket/src/Walsun.Erp.BasketService
docker build --force-rm -t "walsunerp/service-basket:${IMAGE_TAG}" .


echo "**************** BUILDING CATALOG-SERVICE 8/$total ****************"
cd ${currentFolder}/services/catalog/src/Walsun.Erp.CatalogService.HttpApi.Host
docker build --force-rm -t "walsunerp/service-catalog:${IMAGE_TAG}" .


echo "**************** BUILDING PAYMENT-SERVICE 9/$total ****************"
cd ${currentFolder}/services/payment/src/Walsun.Erp.PaymentService.HttpApi.Host
docker build --force-rm -t "walsunerp/service-payment:${IMAGE_TAG}" .


echo "**************** BUILDING ORDERING-SERVICE 10/$total ****************"
cd ${currentFolder}/services/ordering/src/Walsun.Erp.OrderingService.HttpApi.Host
docker build --force-rm -t "walsunerp/service-ordering:${IMAGE_TAG}" .

echo "**************** BUILDING CMSKIT-SERVICE 11/$total ****************"
cd ${currentFolder}/services/cmskit/src/Walsun.Erp.CmskitService.HttpApi.Host
docker build --force-rm -t "walsunerp/service-cmskit:${IMAGE_TAG}" .

echo "ALL COMPLETED"