using Volo.Abp.Modularity;

namespace volo.account.pro;

[DependsOn(
    typeof(proApplicationModule),
    typeof(proDomainTestModule)
    )]
public class proApplicationTestModule : AbpModule
{

}
