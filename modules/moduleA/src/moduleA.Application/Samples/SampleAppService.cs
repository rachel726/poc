using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;
using Volo.Saas.Host;
using Volo.Saas.Host.Dtos;
using Volo.Saas.Tenants;

namespace moduleA.Samples;

public class SampleAppService : ApplicationService, ISampleAppService
{

	private readonly ITenantAppService _tenantAppService;
    public SampleAppService(ITenantAppService tenantAppService)
    {
        _tenantAppService = tenantAppService;
    }
    public Task<SampleDto> GetAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }

    [Authorize]
    public Task<SampleDto> GetAuthorizedAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }


	public async Task Sync(string name, string email)
	{
        Tenant a = null; 
		var newTenant = new SaasTenantCreateDto();
		newTenant.AdminPassword = "1q2w3E*";
		newTenant.Name = name;
		newTenant.AdminEmailAddress = email;
		
		var tenantCreated = await _tenantAppService.CreateAsync(newTenant);

        var x = 20;
	}
}
