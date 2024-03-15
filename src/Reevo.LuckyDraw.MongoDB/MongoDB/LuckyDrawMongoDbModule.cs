using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Reevo.LuckyDraw.MongoDB;

[DependsOn(
    typeof(LuckyDrawDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class LuckyDrawMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<LuckyDrawMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
