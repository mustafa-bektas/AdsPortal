using AdsPortal.Samples;
using Xunit;

namespace AdsPortal.EntityFrameworkCore.Domains;

[Collection(AdsPortalTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AdsPortalEntityFrameworkCoreTestModule>
{

}
