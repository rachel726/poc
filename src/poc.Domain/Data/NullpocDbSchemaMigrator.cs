using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace poc.Data;

/* This is used if database provider does't define
 * IpocDbSchemaMigrator implementation.
 */
public class NullpocDbSchemaMigrator : IpocDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
