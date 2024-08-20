using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace NewModule.EntityFrameworkCore;

[ConnectionStringName(NewModuleDbProperties.ConnectionStringName)]
public class NewModuleDbContext : AbpDbContext<NewModuleDbContext>, INewModuleDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public NewModuleDbContext(DbContextOptions<NewModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureNewModule();
    }
}
