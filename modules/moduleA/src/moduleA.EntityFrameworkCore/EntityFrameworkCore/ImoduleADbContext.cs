using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace moduleA.EntityFrameworkCore;

[ConnectionStringName(moduleADbProperties.ConnectionStringName)]
public interface ImoduleADbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
