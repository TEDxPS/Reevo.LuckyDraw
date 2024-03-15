using Volo.Abp.Modularity;

namespace Reevo.LuckyDraw;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class LuckyDrawApplicationTestBase<TStartupModule> : LuckyDrawTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
