using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Reevo.LuckyDraw.EntityFrameworkCore;

public class LuckyDrawHttpApiHostMigrationsDbContext : AbpDbContext<LuckyDrawHttpApiHostMigrationsDbContext>
{
    public LuckyDrawHttpApiHostMigrationsDbContext(DbContextOptions<LuckyDrawHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureLuckyDraw();
    }
}
