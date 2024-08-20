using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace volo.account.pro.EntityFrameworkCore;

[ConnectionStringName(proDbProperties.ConnectionStringName)]
public class proDbContext : AbpDbContext<proDbContext>, IproDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public proDbContext(DbContextOptions<proDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Configurepro();
    }
}
