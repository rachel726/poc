using volo.account.pro.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace volo.account.pro.Permissions;

public class proPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(proPermissions.GroupName, L("Permission:pro"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<proResource>(name);
    }
}
