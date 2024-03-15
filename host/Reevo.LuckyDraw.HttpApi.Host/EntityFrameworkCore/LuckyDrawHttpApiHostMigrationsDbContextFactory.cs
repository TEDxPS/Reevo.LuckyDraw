using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Reevo.LuckyDraw.EntityFrameworkCore;

public class LuckyDrawHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<LuckyDrawHttpApiHostMigrationsDbContext>
{
    public LuckyDrawHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<LuckyDrawHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("LuckyDraw"));

        return new LuckyDrawHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
