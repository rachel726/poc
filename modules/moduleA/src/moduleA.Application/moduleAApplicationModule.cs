using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace moduleA;

[DependsOn(
    typeof(moduleADomainModule),
    typeof(moduleAApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class moduleAApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<moduleAApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<moduleAApplicationModule>(validate: true);
        });
    }
}
