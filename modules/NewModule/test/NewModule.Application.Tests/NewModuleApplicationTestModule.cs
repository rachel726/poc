using Volo.Abp.Modularity;

namespace NewModule;

[DependsOn(
    typeof(NewModuleApplicationModule),
    typeof(NewModuleDomainTestModule)
    )]
public class NewModuleApplicationTestModule : AbpModule
{

}
