﻿using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace NewModule;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class NewModuleInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<NewModuleInstallerModule>();
        });
    }
}
