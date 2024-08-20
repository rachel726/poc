using Localization.Resources.AbpUi;
using volo.account.pro.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace volo.account.pro;

[DependsOn(
    typeof(proApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class proHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(proHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<proResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
