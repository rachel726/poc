using volo.account.pro.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace volo.account.pro.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class proPageModel : AbpPageModel
{
    protected proPageModel()
    {
        LocalizationResourceType = typeof(proResource);
        ObjectMapperContext = typeof(proWebModule);
    }
}
