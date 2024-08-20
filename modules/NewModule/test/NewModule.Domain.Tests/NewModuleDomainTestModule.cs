using NewModule.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NewModule;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(NewModuleEntityFrameworkCoreTestModule)
    )]
public class NewModuleDomainTestModule : AbpModule
{

}
