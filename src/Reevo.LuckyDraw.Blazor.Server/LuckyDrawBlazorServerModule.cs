using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Reevo.LuckyDraw.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(LuckyDrawBlazorModule)
    )]
public class LuckyDrawBlazorServerModule : AbpModule
{

}
