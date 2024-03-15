using Volo.Abp.Bundling;

namespace Reevo.LuckyDraw.Blazor.Host;

public class LuckyDrawBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
