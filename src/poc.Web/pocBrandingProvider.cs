using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace poc.Web;

[Dependency(ReplaceServices = true)]
public class pocBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "poc";
}
