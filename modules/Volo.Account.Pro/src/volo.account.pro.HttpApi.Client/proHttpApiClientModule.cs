using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace volo.account.pro;

[DependsOn(
    typeof(proApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class proHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(proApplicationContractsModule).Assembly,
            proRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<proHttpApiClientModule>();
        });

    }
}
