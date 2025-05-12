 # Pre-requirements

* Docker Desktop with Kubernetes enabled
* Install [NGINX ingress](https://kubernetes.github.io/ingress-nginx/deploy/) for k8s

    OR

    Install NGINX ingress using helm
```powershell
helm repo add ingress-nginx https://kubernetes.github.io/ingress-nginx
helm repo update

helm upgrade --install --version=4.0.19 ingress-nginx ingress-nginx/ingress-nginx
```
* Install [Helm](https://helm.sh/docs/intro/install/) for running helm charts


# How to run?

* Add entries to the hosts file (in Windows: `C:\Windows\System32\drivers\etc\hosts`, in linux and macos: `/etc/hosts` ):

````powershell
127.0.0.1 erp-st-web
127.0.0.1 erp-st-public-web
127.0.0.1 erp-st-authserver
127.0.0.1 erp-st-identity
127.0.0.1 erp-st-administration
127.0.0.1 erp-st-basket
127.0.0.1 erp-st-catalog
127.0.0.1 erp-st-ordering
127.0.0.1 erp-st-cmskit
127.0.0.1 erp-st-payment
127.0.0.1 erp-st-gateway-web
127.0.0.1 erp-st-gateway-web-public
````
Once Helm is set up properly, add the repo as follows:

```console
helm repo add eshoponabp https://abpframework.github.io/abp-charts/
```
You can then run `helm search repo eshoponabp` to see the charts.

```console
 helm install erp-st eshoponabp/eshoponabp
```

OR

* Run `build-images.ps1` or `build-images.sh` in the `build` directory.
* Run `deploy-staging.ps1` or `deploy-staging.sh` in the `helm-chart` directory. It is deployed with the `erp` namespace.
* *You may wait ~30 seconds on first run for preparing the database*.
* Browse https://erp-st-public-web for public and https://erp-st-web for web application
* Username: `admin`, password: `1q2w3E*`.

# Running on HTTPS

You can also run the staging solution on your local kubernetes kluster with https. There are various ways to create self-signed certificate. 

## Installing mkcert
This guide will use mkcert to create self-signed certificates.

Follow the [installation guide](https://github.com/FiloSottile/mkcert#installation) to install mkcert.

## Creating mkcert Root CA
Use the command to create root (local) certificate authority for your certificates:
```powershell
mkcert -install
```

**Note:** all the certificates created by mkcert certificate creation will be trusted by local machine

## Run mkcert

Create certificate for the eshopOnAbp domains using the mkcert command below:
```powershell
mkcert "walsun.erp.dev" "*.walsunerp.dev"
```

At the end of the output you will see something like

The certificate is at "./erp-st-web+10.pem" and the key at "./erp-st-web+10-key.pem"

Copy the cert name and key name below to create tls secret

```powershell
kubectl create namespace erp
kubectl create secret tls -n erp erp-wildcard-tls --cert=./walsun.erp.dev+1.pem  --key=./walsun.erp.dev+1-key.pem
```
