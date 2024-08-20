using Volo.Abp.Reflection;

namespace moduleA.Permissions;

public class moduleAPermissions
{
    public const string GroupName = "moduleA";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(moduleAPermissions));
    }
}
