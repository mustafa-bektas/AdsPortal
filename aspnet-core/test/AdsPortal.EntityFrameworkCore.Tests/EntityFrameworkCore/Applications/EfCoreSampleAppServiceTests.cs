using AdsPortal.Samples;
using Xunit;

namespace AdsPortal.EntityFrameworkCore.Applications;

[Collection(AdsPortalTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AdsPortalEntityFrameworkCoreTestModule>
{

}
