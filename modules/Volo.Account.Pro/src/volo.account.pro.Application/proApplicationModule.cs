using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace volo.account.pro;

[DependsOn(
    typeof(proDomainModule),
    typeof(proApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class proApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<proApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<proApplicationModule>(validate: true);
        });
    }
}
