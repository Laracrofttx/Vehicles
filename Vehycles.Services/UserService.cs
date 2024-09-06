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
				return IdentityResult.Failed(new IdentityError
				{
					Description =
					"An error occurred during registration. Please try again later."
				});
			}
		}
		public async Task<LoginViewModel> LoginAsync(LoginViewModel model)
		{
			try
			{
				var user = await this.userManager.FindByEmailAsync(model.UserName) ?? throw new ArgumentException("There is no such user.");
				var result = await this.signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);

				if (!result.Succeeded)
				{
					throw new ArgumentException("There was a error while loggin you in! Please try again later or contact an administrator.");
				}

				return new LoginViewModel()
				{
					UserName = model.UserName,
					Password = model.Password,
					RememberMe = model.RememberMe,
				};
			}
			catch (Exception)
			{
				throw new InvalidOperationException("An error occurred during login. Please try again later.");
			}
		}
	}
}
