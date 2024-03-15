using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Reevo.LuckyDraw.MongoDB;

[ConnectionStringName(LuckyDrawDbProperties.ConnectionStringName)]
public class LuckyDrawMongoDbContext : AbpMongoDbContext, ILuckyDrawMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureLuckyDraw();
    }
}
