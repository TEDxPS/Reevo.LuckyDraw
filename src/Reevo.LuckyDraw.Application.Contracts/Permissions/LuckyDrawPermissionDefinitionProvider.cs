using Reevo.LuckyDraw.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Reevo.LuckyDraw.Permissions;

public class LuckyDrawPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LuckyDrawPermissions.GroupName, L("Permission:LuckyDraw"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LuckyDrawResource>(name);
    }
}
