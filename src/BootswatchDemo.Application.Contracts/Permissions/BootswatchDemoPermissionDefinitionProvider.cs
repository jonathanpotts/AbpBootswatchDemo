using BootswatchDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BootswatchDemo.Permissions;

public class BootswatchDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BootswatchDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BootswatchDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BootswatchDemoResource>(name);
    }
}
