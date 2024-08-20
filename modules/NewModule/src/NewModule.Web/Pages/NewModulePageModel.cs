using NewModule.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace NewModule.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class NewModulePageModel : AbpPageModel
{
    protected NewModulePageModel()
    {
        LocalizationResourceType = typeof(NewModuleResource);
        ObjectMapperContext = typeof(NewModuleWebModule);
    }
}
