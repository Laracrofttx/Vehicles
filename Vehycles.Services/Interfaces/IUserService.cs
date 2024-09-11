namespace Vehycles.Services.Interfaces
{
	using Microsoft.AspNetCore.Identity;
	using Vehycle.Web.ViewModels.Account;
	public interface IUserService
	{
		Task<IdentityResult> RegisterAsync(RegisterViewModel model);
		Task<LoginRequestModel> LoginAsync(LoginRequestModel model);
		Task LogoutAsync();
	}
}
