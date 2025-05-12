using Volo.Abp.Reflection;

namespace Walsun.Erp.PaymentService.Permissions
{
    public class PaymentServicePermissions
    {
        public const string GroupName = "PaymentService";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(PaymentServicePermissions));
        }
    }
}