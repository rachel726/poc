using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Security.Claims;
using Volo.Abp.Users;

namespace Volo.Abp.Account.Public.Web.Pages.Account;

[Authorize]
[IgnoreAntiforgeryToken]
public class ImpersonateUserModel : AccountPageModel
{
    [BindProperty(SupportsGet = true)]
    [Required]
    public Guid UserId { get; set; }    

    protected AbpAccountOptions AccountOptions { get; }
    protected IPermissionChecker PermissionChecker { get; }
    protected ICurrentPrincipalAccessor CurrentPrincipalAccessor { get; }
    protected ITenantStore TenantStore { get; }

    public ImpersonateUserModel(
        IOptions<AbpAccountOptions> accountOptions,
        IPermissionChecker permissionChecker,
        ICurrentPrincipalAccessor currentPrincipalAccessor,
        ITenantStore tenantStore)
    {
        AccountOptions = accountOptions.Value;
        PermissionChecker = permissionChecker;
        CurrentPrincipalAccessor = currentPrincipalAccessor;
        TenantStore = tenantStore;
    }

    public virtual Task<IActionResult> OnGetAsync()
    {
        return Task.FromResult<IActionResult>(NotFound());
    }

	//public virtual async Task<IActionResult> OnPostAsync()
	//{
	//    if (CurrentUser.FindImpersonatorUserId() != null)
	//    {
	//        throw new BusinessException("Volo.Account:NestedImpersonationIsNotAllowed");
	//    }

	//    if (UserId == CurrentUser.Id)
	//    {
	//        throw new BusinessException("Volo.Account:YouCanNotImpersonateYourself");
	//    }

	//    if (AccountOptions.ImpersonationUserPermission.IsNullOrWhiteSpace() ||
	//        !await PermissionChecker.IsGrantedAsync(AccountOptions.ImpersonationUserPermission))
	//    {
	//        throw new BusinessException("Volo.Account:RequirePermissionToImpersonateUser")
	//            .WithData("PermissionName", AccountOptions.ImpersonationUserPermission);
	//    }

	//    var user = await UserManager.FindByIdAsync(UserId.ToString());
	//    if (user != null)
	//    {
	//        var isPersistent = (await HttpContext.AuthenticateAsync(IdentityConstants.ApplicationScheme))?.Properties?.IsPersistent ?? false;
	//        await SignInManager.SignOutAsync();

	//        var additionalClaims = new List<Claim>();
	//        if (CurrentUser.Id?.ToString() != CurrentUser.FindClaim(AbpClaimTypes.ImpersonatorUserId)?.Value)
	//        {
	//            additionalClaims.Add(new Claim(AbpClaimTypes.ImpersonatorUserId, CurrentUser.Id.ToString()));
	//            additionalClaims.Add(new Claim(AbpClaimTypes.ImpersonatorUserName, CurrentUser.UserName));
	//            if (CurrentTenant.IsAvailable)
	//            {
	//                additionalClaims.Add(new Claim(AbpClaimTypes.ImpersonatorTenantId, CurrentTenant.Id.ToString()));
	//                var tenantConfiguration = await TenantStore.FindAsync(CurrentTenant.Id.Value);
	//                if (tenantConfiguration != null && !tenantConfiguration.Name.IsNullOrWhiteSpace())
	//                {
	//                    additionalClaims.Add(new Claim(AbpClaimTypes.ImpersonatorTenantName, tenantConfiguration.Name));
	//                }
	//            }
	//        }

	//        await SignInManager.SignInWithClaimsAsync(user, new AuthenticationProperties
	//        {
	//            IsPersistent = isPersistent
	//        }, additionalClaims);

	//        //save security log to admin user.
	//        var userPrincipal = await SignInManager.CreateUserPrincipalAsync(user);
	//        userPrincipal.Identities.First().AddClaims(additionalClaims);
	//        using (CurrentPrincipalAccessor.Change(userPrincipal))
	//        {
	//            await IdentitySecurityLogManager.SaveAsync(new IdentitySecurityLogContext
	//            {
	//                Identity = IdentitySecurityLogIdentityConsts.Identity,
	//                Action = "ImpersonateUser"
	//            });
	//        }

	//        return Redirect("~/");
	//    }

	//    throw new BusinessException("Volo.Account:ThereIsNoUserWithUsernameInTheTenant")
	//        .WithData("UserId", UserId);
	//}

	public virtual async Task<IActionResult> OnPostAsync()
	{

		string tenant1 = "89C7CA69-79E9-DE2B-2FE2-3A135B8E2092";
		string tenant2 = "EE5E9E5C-357F-09C3-076C-3A135B8E8E12";

		//using (CurrentTenant.Change(new Guid("89C7CA69-79E9-DE2B-2FE2-3A135B8E2092")))
		//{
		//    return Redirect("~/");
		//}
		if (CurrentUser.FindImpersonatorUserId() != null)
		{
			throw new BusinessException("Volo.Account:NestedImpersonationIsNotAllowed");
		}
		if (UserId == CurrentUser.Id)
		{
			throw new BusinessException("Volo.Account:YouCanNotImpersonateYourself");
		}
		if (AccountOptions.ImpersonationUserPermission.IsNullOrWhiteSpace() ||
			!await PermissionChecker.IsGrantedAsync(AccountOptions.ImpersonationUserPermission))
		{
			throw new BusinessException("Volo.Account:RequirePermissionToImpersonateUser")
				.WithData("PermissionName", AccountOptions.ImpersonationUserPermission);
		}
		var user = await UserManager.FindByIdAsync(UserId.ToString());
		/**/
		using (CurrentTenant.Change(new Guid(tenant2)))
		{
			user = await UserManager.FindByEmailAsync(user.Email);
		}
		/**/
		if (user != null)
		{
			var isPersistent = (await HttpContext.AuthenticateAsync(IdentityConstants.ApplicationScheme))?.Properties?.IsPersistent ?? false;
			await SignInManager.SignOutAsync();
			var additionalClaims = new List<Claim>();
			if (CurrentUser.Id?.ToString() != CurrentUser.FindClaim(AbpClaimTypes.ImpersonatorUserId)?.Value)
			{
				additionalClaims.Add(new Claim(AbpClaimTypes.ImpersonatorUserId, CurrentUser.Id.ToString()));
				additionalClaims.Add(new Claim(AbpClaimTypes.ImpersonatorUserName, CurrentUser.UserName));
				if (CurrentTenant.IsAvailable)
				{
					additionalClaims.Add(new Claim(AbpClaimTypes.ImpersonatorTenantId, CurrentTenant.Id.ToString()));
					var tenantConfiguration = await TenantStore.FindAsync(CurrentTenant.Id.Value);
					if (tenantConfiguration != null && !tenantConfiguration.Name.IsNullOrWhiteSpace())
					{
						additionalClaims.Add(new Claim(AbpClaimTypes.ImpersonatorTenantName, tenantConfiguration.Name));
					}
				}
			}
			using (CurrentTenant.Change(new Guid(tenant2)))
			{
				await SignInManager.SignInAsync(user, new AuthenticationProperties
				{
					IsPersistent = isPersistent
				});
				//await SignInManager.SignInWithClaimsAsync(user, new AuthenticationProperties
				//{
				//    IsPersistent = isPersistent
				//}, additionalClaims);
			}
			//save security log to admin user.
			var userPrincipal = await SignInManager.CreateUserPrincipalAsync(user);
			userPrincipal.Identities.First().AddClaims(additionalClaims);
			using (CurrentPrincipalAccessor.Change(userPrincipal))
			{
				await IdentitySecurityLogManager.SaveAsync(new IdentitySecurityLogContext
				{
					Identity = IdentitySecurityLogIdentityConsts.Identity,
					Action = "ImpersonateUser"
				});
			}
			return Redirect("~/");
		}
		throw new BusinessException("Volo.Account:ThereIsNoUserWithUsernameInTheTenant")
			.WithData("UserId", UserId);
	}
}
