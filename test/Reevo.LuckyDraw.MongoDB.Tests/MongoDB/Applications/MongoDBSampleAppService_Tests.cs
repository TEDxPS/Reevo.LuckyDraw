using Reevo.LuckyDraw.MongoDB;
using Reevo.LuckyDraw.Samples;
using Xunit;

namespace Reevo.LuckyDraw.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<LuckyDrawMongoDbTestModule>
{

}
