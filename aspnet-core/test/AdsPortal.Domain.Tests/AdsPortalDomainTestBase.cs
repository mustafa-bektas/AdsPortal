using Volo.Abp.Modularity;

namespace AdsPortal;

/* Inherit from this class for your domain layer tests. */
public abstract class AdsPortalDomainTestBase<TStartupModule> : AdsPortalTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
