using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Reevo.LuckyDraw;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LuckyDrawHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class LuckyDrawConsoleApiClientModule : AbpModule
{

}
