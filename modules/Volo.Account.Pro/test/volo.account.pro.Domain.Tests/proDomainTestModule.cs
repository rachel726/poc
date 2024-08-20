using volo.account.pro.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace volo.account.pro;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(proEntityFrameworkCoreTestModule)
    )]
public class proDomainTestModule : AbpModule
{

}
