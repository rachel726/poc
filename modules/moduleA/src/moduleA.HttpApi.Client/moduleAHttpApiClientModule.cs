using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace moduleA;

[DependsOn(
    typeof(moduleAApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class moduleAHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(moduleAApplicationContractsModule).Assembly,
            moduleARemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<moduleAHttpApiClientModule>();
        });
    }
}
