using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using System;
using Volo.Abp.Account.Public.Web.Pages.Account;
using Volo.Abp.Account.Public.Web;
using Volo.Abp.Account.Web.Pages.Account;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;
using Volo.Abp.OpenIddict;
using Volo.Saas.Tenants;
using Volo.Abp.Account.Security.Recaptcha;
using Volo.Abp.Account.ExternalProviders;
using Volo.Abp.Security.Claims;
using Owl.reCAPTCHA;
namespace POC.Web.Pages.Account
{
	[ExposeServices(typeof(LoginModel))]
	public class MyLoginModel : OpenIddictProSupportedLoginModel
	{
		private readonly ITenantRepository _tenantRepository;
		//private readonly ITenantsManagementService itenantmanagementService;
		//private readonly IUserService _userService;
		public MyLoginModel(IAuthenticationSchemeProvider schemeProvider,
		IOptions<AbpAccountOptions> accountOptions,
		IAbpRecaptchaValidatorFactory recaptchaValidatorFactory,
		IAccountExternalProviderAppService accountExternalProviderAppService,
		ICurrentPrincipalAccessor currentPrincipalAccessor,
		IOptions<IdentityOptions> identityOptions,
		IOptionsSnapshot<reCAPTCHAOptions> reCaptchaOptions,
		AbpOpenIddictRequestHelper openIddictRequestHelper)
			: base(schemeProvider, accountOptions, recaptchaValidatorFactory, accountExternalProviderAppService, currentPrincipalAccessor, identityOptions, reCaptchaOptions, openIddictRequestHelper
				)
		{
			//_userService = userService;
			//_tenantRepository = tenantRepository;
		}
		[AllowAnonymous]
		public override async Task<IActionResult> OnPostAsync(string action)
		{
			var tenantId = await FindTenantOfUserAsync(LoginInput.UserNameOrEmailAddress);
			using (CurrentTenant.Change(tenantId))
			{
				return await base.OnPostAsync(action);
			}
		}
		[AllowAnonymous]
		public override async Task<IActionResult> OnGetExternalLoginCallbackAsync(string returnUrl = "", string returnUrlHash = "", string remoteError = null)
		{
			var tenantId = await FindTenantOfUserAsync(LoginInput.UserNameOrEmailAddress);
			using (CurrentTenant.Change(tenantId))
			{
				Console.WriteLine(CurrentTenant);
				return await base.OnGetExternalLoginCallbackAsync(returnUrl, returnUrlHash, remoteError);
			}
		}
		[AllowAnonymous]
		protected async Task<Guid?> FindTenantOfUserAsync(string uniqueUserNameOrEmailAddress)
		{
			// change to specific tenant
			string tenant1 = "89C7CA69-79E9-DE2B-2FE2-3A135B8E2092";
			string tenant2 = "EE5E9E5C-357F-09C3-076C-3A135B8E8E12";

			return new Guid(tenant1);
			//return new Guid(tenant2);

			return null;
			//return await _userService.GetTenantOfUserByEmail(LoginInput.UserNameOrEmailAddress);
		}
	}
}