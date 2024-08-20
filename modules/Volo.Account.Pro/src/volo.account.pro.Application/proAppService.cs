using volo.account.pro.Localization;
using Volo.Abp.Application.Services;

namespace volo.account.pro;

public abstract class proAppService : ApplicationService
{
    protected proAppService()
    {
        LocalizationResource = typeof(proResource);
        ObjectMapperContext = typeof(proApplicationModule);
    }
}
