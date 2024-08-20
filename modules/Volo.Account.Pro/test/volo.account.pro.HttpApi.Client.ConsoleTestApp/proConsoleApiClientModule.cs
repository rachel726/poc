using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace volo.account.pro;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(proHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class proConsoleApiClientModule : AbpModule
{

}
