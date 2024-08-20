using poc.Localization;
using Volo.Abp.Application.Services;

namespace poc;

/* Inherit your application services from this class.
 */
public abstract class pocAppService : ApplicationService
{
    protected pocAppService()
    {
        LocalizationResource = typeof(pocResource);
    }
}
