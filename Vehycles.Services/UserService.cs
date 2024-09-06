namespace Vehycles.Services
{
	using Microsoft.AspNetCore.Identity;
	using System.Threading.Tasks;
	using Vehycle.Data.Models;
	using Vehycle.Web.ViewModels.Account;
	using Vehycles.Services.Interfaces;
	public class UserService : IUserService
	{
		private readonly UserManager<ApplicationUser> userManager;
		private readonly SignInManager<ApplicationUser> signInManager;

		public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
		}
		public Task LoginAsync(LoginViewModel model)
		{
			throw new NotImplementedException();
		}

		public async Task<IdentityResult> RegisterAsync(RegisterViewModel model)
		{
			try
			{
				var userExist = userManager.FindByEmailAsync(model.EmailAddress);
				if (userExist != null) 
				{
					throw new ArgumentException("User with this email already exists.");
				}

				var user = new ApplicationUser { UserName = model.UserName, Email = model.EmailAddress };
				var result = await userManager.CreateAsync(user, model.Password);

				if (result.Succeeded) 
				{
					await this.signInManager.SignInAsync(user, isPersistent: false);
				}
				return result;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
