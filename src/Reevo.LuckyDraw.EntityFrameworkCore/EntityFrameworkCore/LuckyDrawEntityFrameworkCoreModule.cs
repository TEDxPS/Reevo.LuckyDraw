using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Reevo.LuckyDraw.EntityFrameworkCore;

[DependsOn(
    typeof(LuckyDrawDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class LuckyDrawEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<LuckyDrawDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
