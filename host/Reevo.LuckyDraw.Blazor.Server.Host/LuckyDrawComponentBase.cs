using Reevo.LuckyDraw.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Reevo.LuckyDraw.Blazor.Server.Host;

public abstract class LuckyDrawComponentBase : AbpComponentBase
{
    protected LuckyDrawComponentBase()
    {
        LocalizationResource = typeof(LuckyDrawResource);
    }
}
