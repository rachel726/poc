using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace NewModule;

[DependsOn(
    typeof(NewModuleApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class NewModuleHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(NewModuleApplicationContractsModule).Assembly,
            NewModuleRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<NewModuleHttpApiClientModule>();
        });

    }
}
