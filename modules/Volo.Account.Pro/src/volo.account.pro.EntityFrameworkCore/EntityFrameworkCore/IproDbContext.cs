using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace volo.account.pro.EntityFrameworkCore;

[ConnectionStringName(proDbProperties.ConnectionStringName)]
public interface IproDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
