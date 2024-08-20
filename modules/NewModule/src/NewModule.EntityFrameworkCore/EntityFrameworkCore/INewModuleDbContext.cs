using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace NewModule.EntityFrameworkCore;

[ConnectionStringName(NewModuleDbProperties.ConnectionStringName)]
public interface INewModuleDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
