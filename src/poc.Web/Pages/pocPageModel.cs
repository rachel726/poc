using poc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace poc.Web.Pages;

public abstract class pocPageModel : AbpPageModel
{
    protected pocPageModel()
    {
        LocalizationResourceType = typeof(pocResource);
    }
}
