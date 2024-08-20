using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace moduleA;

[DependsOn(
    typeof(moduleADomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationAbstractionsModule)
    )]
public class moduleAApplicationContractsModule : AbpModule
{

}
