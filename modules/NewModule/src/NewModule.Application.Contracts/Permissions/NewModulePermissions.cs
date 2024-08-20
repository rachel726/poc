using Volo.Abp.Reflection;

namespace NewModule.Permissions;

public class NewModulePermissions
{
    public const string GroupName = "NewModule";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(NewModulePermissions));
    }
}
