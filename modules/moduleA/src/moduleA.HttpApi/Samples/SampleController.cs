using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace moduleA.Samples;

[Area(moduleARemoteServiceConsts.ModuleName)]
[RemoteService(Name = moduleARemoteServiceConsts.RemoteServiceName)]
[Route("api/moduleA/sample")]
public class SampleController : moduleAController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
	}

	[HttpPost]
	public async Task Sync(string name, string email)
	{
		 await _sampleAppService.Sync(name, email);
	}
}
