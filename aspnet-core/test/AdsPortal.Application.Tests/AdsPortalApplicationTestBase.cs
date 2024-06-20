using Volo.Abp.Modularity;

namespace AdsPortal;

public abstract class AdsPortalApplicationTestBase<TStartupModule> : AdsPortalTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
