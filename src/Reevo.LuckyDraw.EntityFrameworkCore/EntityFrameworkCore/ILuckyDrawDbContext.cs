using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Reevo.LuckyDraw.EntityFrameworkCore;

[ConnectionStringName(LuckyDrawDbProperties.ConnectionStringName)]
public interface ILuckyDrawDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
