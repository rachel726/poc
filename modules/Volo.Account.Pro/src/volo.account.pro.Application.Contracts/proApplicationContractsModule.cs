using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace volo.account.pro;

[DependsOn(
    typeof(proDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class proApplicationContractsModule : AbpModule
{

}
