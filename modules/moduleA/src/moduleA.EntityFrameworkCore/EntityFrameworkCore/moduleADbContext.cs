﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace moduleA.EntityFrameworkCore;

[ConnectionStringName(moduleADbProperties.ConnectionStringName)]
public class moduleADbContext : AbpDbContext<moduleADbContext>, ImoduleADbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public moduleADbContext(DbContextOptions<moduleADbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfiguremoduleA();
    }
}
