using Localization.Resources.AbpUi;
using NewModule.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace NewModule;

[DependsOn(
    typeof(NewModuleApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class NewModuleHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(NewModuleHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<NewModuleResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
