using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Reevo.LuckyDraw;

[Dependency(ReplaceServices = true)]
public class LuckyDrawBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LuckyDraw";
}
