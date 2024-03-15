using Reevo.LuckyDraw.Samples;
using Xunit;

namespace Reevo.LuckyDraw.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<LuckyDrawMongoDbTestModule>
{

}
