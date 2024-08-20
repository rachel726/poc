using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace NewModule;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NewModuleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class NewModuleConsoleApiClientModule : AbpModule
{

}
