using moduleA.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace moduleA.Permissions;

public class moduleAPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(moduleAPermissions.GroupName, L("Permission:moduleA"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<moduleAResource>(name);
    }
}
