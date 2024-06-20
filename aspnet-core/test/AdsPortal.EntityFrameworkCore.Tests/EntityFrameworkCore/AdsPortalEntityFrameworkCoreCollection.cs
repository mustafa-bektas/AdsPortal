using Xunit;

namespace AdsPortal.EntityFrameworkCore;

[CollectionDefinition(AdsPortalTestConsts.CollectionDefinitionName)]
public class AdsPortalEntityFrameworkCoreCollection : ICollectionFixture<AdsPortalEntityFrameworkCoreFixture>
{

}
