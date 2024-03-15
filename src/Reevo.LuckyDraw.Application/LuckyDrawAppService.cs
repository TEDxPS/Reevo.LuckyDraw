using Reevo.LuckyDraw.Localization;
using Volo.Abp.Application.Services;

namespace Reevo.LuckyDraw;

public abstract class LuckyDrawAppService : ApplicationService
{
    protected LuckyDrawAppService()
    {
        LocalizationResource = typeof(LuckyDrawResource);
        ObjectMapperContext = typeof(LuckyDrawApplicationModule);
    }
}
