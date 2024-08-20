using NewModule.Localization;
using Volo.Abp.Application.Services;

namespace NewModule;

public abstract class NewModuleAppService : ApplicationService
{
    protected NewModuleAppService()
    {
        LocalizationResource = typeof(NewModuleResource);
        ObjectMapperContext = typeof(NewModuleApplicationModule);
    }
}
