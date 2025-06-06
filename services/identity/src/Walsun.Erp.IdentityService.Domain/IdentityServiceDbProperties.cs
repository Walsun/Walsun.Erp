﻿namespace Walsun.Erp.IdentityService
{
    public static class IdentityServiceDbProperties
    {
        public static string DbTablePrefix { get; set; } = "";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "IdentityService";
        
        public const string DefaultAdminEmailAddress = "admin@abp.io";
        
        public const string DefaultAdminPassword = "1q2w3E*";
        public const string CustomerRoleName = "customer";
    }
}
