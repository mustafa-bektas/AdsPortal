using Volo.Abp.Modularity;

namespace AdsPortal;

[DependsOn(
    typeof(AdsPortalDomainModule),
    typeof(AdsPortalTestBaseModule)
)]
public class AdsPortalDomainTestModule : AbpModule
{

}
