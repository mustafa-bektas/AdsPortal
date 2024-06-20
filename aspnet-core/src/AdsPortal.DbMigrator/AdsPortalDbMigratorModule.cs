using AdsPortal.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AdsPortal.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdsPortalEntityFrameworkCoreModule),
    typeof(AdsPortalApplicationContractsModule)
    )]
public class AdsPortalDbMigratorModule : AbpModule
{
}
