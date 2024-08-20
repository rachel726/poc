using poc.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace poc;

[DependsOn(
    typeof(pocEntityFrameworkCoreTestModule)
    )]
public class pocDomainTestModule : AbpModule
{

}
