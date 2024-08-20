using moduleA.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace moduleA;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(moduleAEntityFrameworkCoreTestModule)
    )]
public class moduleADomainTestModule : AbpModule
{

}
