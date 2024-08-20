using volo.account.pro.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace volo.account.pro;

public abstract class proController : AbpControllerBase
{
    protected proController()
    {
        LocalizationResource = typeof(proResource);
    }
}
