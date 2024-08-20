using System.Threading.Tasks;

namespace poc.Data;

public interface IpocDbSchemaMigrator
{
    Task MigrateAsync();
}
