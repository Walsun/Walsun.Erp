﻿using AutoMapper;
using Walsun.Erp.IdentityService.Keycloak.Service;
using Keycloak.Net.Models.Roles;
using Keycloak.Net.Models.Users;

namespace Walsun.Erp.IdentityService;

public class WalsunErpIdentityServiceAutoMapperProfile : Profile
{
    public WalsunErpIdentityServiceAutoMapperProfile()
    {
        CreateMap<User, CachedKeycloakUser>().ReverseMap();
        CreateMap<UserAccess, CachedUserAccess>().ReverseMap();
        CreateMap<UserConsent, CachedUserConsent>().ReverseMap();
        CreateMap<Credentials, CachedCredentials>().ReverseMap();
        CreateMap<FederatedIdentity, CachedFederatedIdentity>();
        
        CreateMap<Role, CachedKeycloakRole>().ReverseMap();
        CreateMap<RoleComposite, CachedRoleComposite>().ReverseMap();
    }
}