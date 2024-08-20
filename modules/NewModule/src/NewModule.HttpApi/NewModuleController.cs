using NewModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NewModule;

public abstract class NewModuleController : AbpControllerBase
{
    protected NewModuleController()
    {
        LocalizationResource = typeof(NewModuleResource);
    }
}
