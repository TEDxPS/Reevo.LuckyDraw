using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Reevo.LuckyDraw;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class LuckyDrawInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<LuckyDrawInstallerModule>();
        });
    }
}
