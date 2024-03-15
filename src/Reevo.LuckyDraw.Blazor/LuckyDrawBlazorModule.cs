using Microsoft.Extensions.DependencyInjection;
using Reevo.LuckyDraw.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Reevo.LuckyDraw.Blazor;

[DependsOn(
    typeof(LuckyDrawApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class LuckyDrawBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<LuckyDrawBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<LuckyDrawBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new LuckyDrawMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(LuckyDrawBlazorModule).Assembly);
        });
    }
}
