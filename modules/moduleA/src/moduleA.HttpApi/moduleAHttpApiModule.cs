using Localization.Resources.AbpUi;
using moduleA.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace moduleA;

[DependsOn(
    typeof(moduleAApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class moduleAHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(moduleAHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<moduleAResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
