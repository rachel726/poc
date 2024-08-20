using moduleA.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace moduleA;

public abstract class moduleAController : AbpControllerBase
{
    protected moduleAController()
    {
        LocalizationResource = typeof(moduleAResource);
    }
}
