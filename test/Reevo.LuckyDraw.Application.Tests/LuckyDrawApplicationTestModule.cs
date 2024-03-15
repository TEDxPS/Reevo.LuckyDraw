using Volo.Abp.Modularity;

namespace Reevo.LuckyDraw;

[DependsOn(
    typeof(LuckyDrawApplicationModule),
    typeof(LuckyDrawDomainTestModule)
    )]
public class LuckyDrawApplicationTestModule : AbpModule
{

}
