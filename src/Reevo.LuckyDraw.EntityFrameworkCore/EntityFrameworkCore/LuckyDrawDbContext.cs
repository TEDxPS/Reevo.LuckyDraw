using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Reevo.LuckyDraw.EntityFrameworkCore;

[ConnectionStringName(LuckyDrawDbProperties.ConnectionStringName)]
public class LuckyDrawDbContext : AbpDbContext<LuckyDrawDbContext>, ILuckyDrawDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public LuckyDrawDbContext(DbContextOptions<LuckyDrawDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureLuckyDraw();
    }
}
