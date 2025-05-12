using Volo.Abp.Reflection;

namespace Walsun.Erp.CmskitService.Permissions;

public class CmskitServicePermissions
{
    public const string GroupName = "CmskitService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CmskitServicePermissions));
    }
}
