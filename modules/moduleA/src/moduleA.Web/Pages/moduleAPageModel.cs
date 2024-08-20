using moduleA.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace moduleA.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class moduleAPageModel : AbpPageModel
{
    protected moduleAPageModel()
    {
        LocalizationResourceType = typeof(moduleAResource);
        ObjectMapperContext = typeof(moduleAWebModule);
    }
}
