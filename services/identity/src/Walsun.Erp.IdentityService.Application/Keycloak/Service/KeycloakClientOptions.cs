﻿namespace Walsun.Erp.IdentityService.Keycloak.Service;
    public class KeycloakClientOptions
    {
        public string Url { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
        public string RealmName { get; set; }
    }