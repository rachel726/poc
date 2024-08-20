using Volo.Abp.Modularity;

namespace poc;

[DependsOn(
    typeof(pocApplicationModule),
    typeof(pocDomainTestModule)
    )]
public class pocApplicationTestModule : AbpModule
{

}
