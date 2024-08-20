using NewModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NewModule.Permissions;

public class NewModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NewModulePermissions.GroupName, L("Permission:NewModule"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NewModuleResource>(name);
    }
}
