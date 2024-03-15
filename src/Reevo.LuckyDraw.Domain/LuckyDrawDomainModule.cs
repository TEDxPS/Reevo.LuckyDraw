using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Reevo.LuckyDraw;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(LuckyDrawDomainSharedModule)
)]
public class LuckyDrawDomainModule : AbpModule
{

}
