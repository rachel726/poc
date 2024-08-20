using Volo.Abp.Modularity;

namespace moduleA;

[DependsOn(
    typeof(moduleAApplicationModule),
    typeof(moduleADomainTestModule)
    )]
public class moduleAApplicationTestModule : AbpModule
{

}
