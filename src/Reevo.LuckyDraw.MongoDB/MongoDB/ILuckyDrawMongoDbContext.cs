using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Reevo.LuckyDraw.MongoDB;

[ConnectionStringName(LuckyDrawDbProperties.ConnectionStringName)]
public interface ILuckyDrawMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
