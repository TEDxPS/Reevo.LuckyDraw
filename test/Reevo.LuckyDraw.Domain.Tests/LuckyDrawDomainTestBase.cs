using Volo.Abp.Modularity;

namespace Reevo.LuckyDraw;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class LuckyDrawDomainTestBase<TStartupModule> : LuckyDrawTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
