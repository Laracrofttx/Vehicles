namespace Vehycles.Services.Interfaces
{
	using Microsoft.AspNetCore.Identity;
	using Vehycle.Web.ViewModels.Account;
	public interface IUserService
	{
		 Task<IdentityResult> RegisterAsync(RegisterViewModel model);
		 Task<LoginResponseModel> LoginAsync(LoginRequestModel model);
	}
}
