using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace moduleA;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(moduleAHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class moduleAConsoleApiClientModule : AbpModule
{

}
