using Reevo.LuckyDraw.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Reevo.LuckyDraw;

public abstract class LuckyDrawController : AbpControllerBase
{
    protected LuckyDrawController()
    {
        LocalizationResource = typeof(LuckyDrawResource);
    }
}
