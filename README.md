# WalsunErp

This is a reference project for those who want to build microservice solutions with the ABP Framework.

> ⚠️ **Important Notice**  
> This project is based on "eshoponabp" that is outdated. It served as a reference project for microservice architecture using the ABP Framework, but we now recommend using the [ABP Microservice Solution Template](https://abp.io/docs/latest/solution-templates/microservice) for new projects.  
>  
> The new template offers a modernized and officially supported starting point for building microservices with ABP. Please consider transitioning to the new template for the latest features and improvements.

## Issues

Please open issues on the main GitHub repository: https://github.com/abpframework/abp/issues
Rabbit MQ ref: https://blog.csdn.net/qq_41929714/article/details/146152629
Rabbit MQ ref: https://blog.csdn.net/weixin_42487712/article/details/145509981

## How to Run?

You can run it in Visual Studio or use [Microsoft Tye](https://github.com/dotnet/tye). Tye is a developer tool that makes developing, testing, and deploying micro-services and distributed applications easier.

 ### Requirements

- .NET 6.0 Runtime (required for TYE)
- .NET 9.0 SDK
- Docker
- Yarn v1.20+(not v2) or npm v6+ (already installed with Node)

### Instructions

- Clone the repository ( [eShopOnAbp](https://github.com/abpframework/eShopOnAbp) )

- Install Tye (*follow [these steps](https://github.com/dotnet/tye/blob/main/docs/getting_started.md#installing-tye)*)
    ```bash
    dotnet tool update --global Microsoft.Tye --prerelease
    ```
- Rename `.env.example` file to `.env` file and provide PayPal ClientID and Secret.

- Execute `run-tye.ps1`

- Wait until all applications are up!

	- You can check the running application from `tye` dashboard ([localhost:8000](http://127.0.0.1:8000/))
	- **Note**: If you see all of your applications keep restarting on `tye` dashboard or `tye` console, you may be facing SSL certificate issues. To diagnose the problems better, check any application logs. If it is related to SSL, developer certificate creation may have failed because of Powershell issues regarding authorization. Check the PowerShell script running configuration and set the policy for your local machine as follows: 
	```bash
	Get-ExecutionPolicy -list
	Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope LocalMachine
	```
	See [Microsoft Powershell documentation](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.security/get-executionpolicy?view=powershell-7.2) for more information.

- After all your backend services are up, start the angular application:

  ```bash
  cd apps/angular
  yarn start
  ```

### Certificate Expiration
If the certificate is expired, you'll see the following error:

<!-- Make it smaller with 320px height  -->
<img src="docs/images/ssl-error.png" height="320"/>

Generating a new certificate will fix that issue. To generate a new one,

- Remove `etc/dev-cert/localhost.pfx`

- Manually execute `create-certificate.ps1` **or** re-run solution with `run-tye.ps1`


### KeyCloak
>[中文指南](https://keycloak.java.net.cn/server/db)
#### 配置PostgreSQL
- 安装数据库驱动程序
	- 下载[`ojdbc17`](https://repo1.maven.org/maven2/com/oracle/database/jdbc/ojdbc17/23.6.0.24.10/ojdbc17-23.6.0.24.10.jar)
	- 下载[`orai18n`](https://repo1.maven.org/maven2/com/oracle/database/nls/orai18n/23.6.0.24.10/orai18n-23.6.0.24.10.jar)
	- 将下载的`ojdbc17.jar`和`orai18n.jar`放到`KeyCloak`的`providers`目录下
- 数据库准备
	- 安装`PostgreSQL 17`
	- 添加用户 ```CREATE USER keycloak WITH PASSWORD 'your-password';```
	- 创建数据库 `keycloak`<img src="docs/images/create-db-keycloak.png" height="320"/>
- 修改`KeyCloak`配置 `conf/keycloak.conf`
```sh
db=postgres
db-username=keycloak
db-password=your-password
db-url=jdbc:postgresql://localhost/keycloak
```
- 启动`KeyCloak`服务，如：`kc start-dev`


## Roadmap
### Version 1.0

- [x] New blank micro-service solution ✔️
- [x] Creating Deployment Scenarios ✔️
- [x] Creating empty business services ✔️
- [x] Implementing	 business logic into services ✔️
- [x] Payment with PayPal ✔️
- [x] Basket, Catalog, Order Service ✔️
- [x] Docker Image creation ✔️
- [x] Helm deployment for local k8s cluster ✔️
- [x] Switch Ocelot to <strike>Envoy</strike> YARP in Public Web gateway ✔️
- [x] Use gRPC for catalog microservice ✔️
- [x] Management Side of Services ✔️
- [x] Administration application (to manage products and orders with a dashboard) ✔️
- [x] Deployment to azure k8s ✔️
### Version 2.0
- [x] Product-detail page on the shopping application (with CMS-kit integration for comments and rating components) ✔️
- [x] Switch to Keycloak from IdentityServer in AuthServer
- [ ] Re-design authorization/permission management
- [ ] Integrate a new sample microservice written in GoLang (Or Python / Java)
### Documentation

- [ ] We will create an e-book to explain the solution

## Current Architecture

![eSopOnAbp Phase 1](/docs/roadmap/Phase_1.png)

## ABP Community Talks

We've organized a meetup related to this solution. You can watch it here: https://community.abp.io/events/microservice-development-iv7d46ov
