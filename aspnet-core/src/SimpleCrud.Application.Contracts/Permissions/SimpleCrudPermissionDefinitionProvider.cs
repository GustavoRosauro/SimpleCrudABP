using SimpleCrud.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SimpleCrud.Permissions;

public class SimpleCrudPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SimpleCrudPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SimpleCrudPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SimpleCrudResource>(name);
    }
}
