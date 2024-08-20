using poc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace poc.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class pocController : AbpControllerBase
{
    protected pocController()
    {
        LocalizationResource = typeof(pocResource);
    }
}
