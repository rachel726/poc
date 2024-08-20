using poc.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace poc.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(pocEntityFrameworkCoreModule),
    typeof(pocApplicationContractsModule)
)]
public class pocDbMigratorModule : AbpModule
{

}
