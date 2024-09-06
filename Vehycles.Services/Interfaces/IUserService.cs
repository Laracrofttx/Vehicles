namespace Vehycles.Services.Interfaces
{
	using Microsoft.AspNetCore.Identity;
	using Vehycle.Web.ViewModels.Account;
	public interface IUserService
	{
		public Task<IdentityResult> RegisterAsync(RegisterViewModel model);
		public Task<LoginViewModel> LoginAsync(LoginViewModel model);
	}
}
