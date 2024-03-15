using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Reevo.LuckyDraw.MongoDB;

public static class LuckyDrawMongoDbContextExtensions
{
    public static void ConfigureLuckyDraw(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
