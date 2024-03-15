using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Reevo.LuckyDraw;

[DependsOn(
    typeof(LuckyDrawApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class LuckyDrawHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(LuckyDrawApplicationContractsModule).Assembly,
            LuckyDrawRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<LuckyDrawHttpApiClientModule>();
        });

    }
}
