using moduleA.Localization;
using Volo.Abp.Application.Services;

namespace moduleA;

public abstract class moduleAAppService : ApplicationService
{
    protected moduleAAppService()
    {
        LocalizationResource = typeof(moduleAResource);
        ObjectMapperContext = typeof(moduleAApplicationModule);
    }
}
