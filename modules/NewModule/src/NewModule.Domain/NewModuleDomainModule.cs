using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace NewModule;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(NewModuleDomainSharedModule)
)]
public class NewModuleDomainModule : AbpModule
{

}
