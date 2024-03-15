using Reevo.LuckyDraw.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Reevo.LuckyDraw.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class LuckyDrawPageModel : AbpPageModel
{
    protected LuckyDrawPageModel()
    {
        LocalizationResourceType = typeof(LuckyDrawResource);
        ObjectMapperContext = typeof(LuckyDrawWebModule);
    }
}
