using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Reevo.LuckyDraw.Blazor.WebAssembly;

[DependsOn(
    typeof(LuckyDrawBlazorModule),
    typeof(LuckyDrawHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class LuckyDrawBlazorWebAssemblyModule : AbpModule
{

}
