using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace Reevo.LuckyDraw.MongoDB;

[DependsOn(
    typeof(LuckyDrawApplicationTestModule),
    typeof(LuckyDrawMongoDbModule)
)]
public class LuckyDrawMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
