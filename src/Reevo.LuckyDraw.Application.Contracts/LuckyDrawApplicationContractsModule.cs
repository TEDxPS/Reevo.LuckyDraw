using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Reevo.LuckyDraw;

[DependsOn(
    typeof(LuckyDrawDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class LuckyDrawApplicationContractsModule : AbpModule
{

}
