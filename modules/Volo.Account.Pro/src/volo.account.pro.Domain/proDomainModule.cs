using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace volo.account.pro;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(proDomainSharedModule)
)]
public class proDomainModule : AbpModule
{

}
