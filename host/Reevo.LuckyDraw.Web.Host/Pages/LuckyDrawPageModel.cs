using Reevo.LuckyDraw.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Reevo.LuckyDraw.Pages;

public abstract class LuckyDrawPageModel : AbpPageModel
{
    protected LuckyDrawPageModel()
    {
        LocalizationResourceType = typeof(LuckyDrawResource);
    }
}
