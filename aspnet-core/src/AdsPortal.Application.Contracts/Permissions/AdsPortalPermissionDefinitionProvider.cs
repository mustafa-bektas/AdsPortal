using AdsPortal.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AdsPortal.Permissions;

public class AdsPortalPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AdsPortalPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AdsPortalPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AdsPortalResource>(name);
    }
}
