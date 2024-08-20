using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
namespace NewModule.Samples;


public class SampleAppService : NewModuleAppService, ISampleAppService
{


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
}











//public class TryService : ApplicationService, ITryService
//{
//	private readonly ITenantAppService _tenantAppService;
//	public TryService(ITenantAppService tenantAppService)
//	{
//		_tenantAppService = tenantAppService;
//	}
//	public async Task Sync()
//	{
//		var newTenant = new SaasTenantCreateDto();
//		newTenant.AdminPassword = "1q2w3E*";
//		newTenant.Name = "rachel";
//		newTenant.AdminEmailAddress = "rachel@gmail.com";
//		newTenant.ExtraProperties.Add("CommunicationStatus", 0);
//		newTenant.ExtraProperties.Add("TaxNumber", "9999");
//		newTenant.ExtraProperties.Add("PhoneNumber", "0548475726");
//		newTenant.ExtraProperties.Add("Employees", "1");
//		var tenantCreated = await _tenantAppService.CreateAsync(newTenant);
//		//await _unitOfWorkManager.Current.SaveChangesAsync();
//	}
//}
