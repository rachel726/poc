using Volo.Abp.Reflection;

namespace volo.account.pro.Permissions;

public class proPermissions
{
    public const string GroupName = "pro";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(proPermissions));
    }
}
