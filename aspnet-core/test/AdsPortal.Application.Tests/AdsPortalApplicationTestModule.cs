using Volo.Abp.Modularity;

namespace AdsPortal;

[DependsOn(
    typeof(AdsPortalApplicationModule),
    typeof(AdsPortalDomainTestModule)
)]
public class AdsPortalApplicationTestModule : AbpModule
{

}
