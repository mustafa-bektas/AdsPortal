using System.Threading.Tasks;

namespace AdsPortal.Data;

public interface IAdsPortalDbSchemaMigrator
{
    Task MigrateAsync();
}
