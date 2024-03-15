using Volo.Abp.Reflection;

namespace Reevo.LuckyDraw.Permissions;

public class LuckyDrawPermissions
{
    public const string GroupName = "LuckyDraw";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(LuckyDrawPermissions));
    }
}
