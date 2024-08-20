using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace volo.account.pro;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class proInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<proInstallerModule>();
        });
    }
}
