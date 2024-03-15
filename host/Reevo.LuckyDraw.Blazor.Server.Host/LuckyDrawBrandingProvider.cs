using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Reevo.LuckyDraw.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class LuckyDrawBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LuckyDraw";
}
