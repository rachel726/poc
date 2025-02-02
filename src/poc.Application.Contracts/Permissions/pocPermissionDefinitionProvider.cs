using poc.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace poc.Permissions;

public class pocPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(pocPermissions.GroupName);

        myGroup.AddPermission(pocPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        myGroup.AddPermission(pocPermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(pocPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<pocResource>(name);
    }
}
