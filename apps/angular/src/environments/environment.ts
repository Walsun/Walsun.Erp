import { MyEnvironment } from './my-environment';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'WalsunErp',
  },
  oAuthConfig: {
    issuer: 'http://localhost:8080/realms/master',
    redirectUri: baseUrl,
    clientId: 'Web',
    responseType: 'code',
    scope: 'offline_access openid profile email phone roles AdministrationService IdentityService BasketService CatalogService OrderingService PaymentService CmskitService', 
    //requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44372',
      rootNamespace: 'WalsunErp',
    },
    Catalog: {
      url: 'https://localhost:44354',
      rootNamespace: 'Walsun.Erp.CatalogService',
    },
    Ordering: {
      url: "https://localhost:44356",
      rootNamespace: 'Walsun.Erp.OrderingService',
    }
  },
  mediaServerUrl:'https://localhost:44373'
} as MyEnvironment;


