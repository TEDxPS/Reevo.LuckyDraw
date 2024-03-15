using Localization.Resources.AbpUi;
using Reevo.LuckyDraw.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Reevo.LuckyDraw;

[DependsOn(
    typeof(LuckyDrawApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class LuckyDrawHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(LuckyDrawHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<LuckyDrawResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
