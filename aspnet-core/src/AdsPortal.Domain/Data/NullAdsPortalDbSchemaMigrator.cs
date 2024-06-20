using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AdsPortal.Data;

/* This is used if database provider does't define
 * IAdsPortalDbSchemaMigrator implementation.
 */
public class NullAdsPortalDbSchemaMigrator : IAdsPortalDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
