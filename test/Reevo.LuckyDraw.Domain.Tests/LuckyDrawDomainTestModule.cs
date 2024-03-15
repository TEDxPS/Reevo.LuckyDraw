using Volo.Abp.Modularity;

namespace Reevo.LuckyDraw;

[DependsOn(
    typeof(LuckyDrawDomainModule),
    typeof(LuckyDrawTestBaseModule)
)]
public class LuckyDrawDomainTestModule : AbpModule
{

}
