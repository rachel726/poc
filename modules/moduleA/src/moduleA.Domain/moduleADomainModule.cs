using Volo.Abp.Caching;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace moduleA;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AbpCachingModule),
    typeof(moduleADomainSharedModule)
)]
public class moduleADomainModule : AbpModule
{

}
