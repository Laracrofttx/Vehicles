using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vehycle.Web.ViewModels.Account;
using Vehycles.Services.Interfaces;

namespace Vehycles.Web.Controllers
{
	public class UserController : Controller
	{
		private readonly IUserService userService;

		public UserController(IUserService userService)
		{
			this.userService = userService;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			try
			{
				var result = await this.userService.RegisterAsync(model);

				if (!result.Succeeded)
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError(string.Empty, error.Description);
					}
					return BadRequest(ModelState);
				}
				else
				{
					return Ok(new { Message = "The user was registered successfully!" });
				}
			}
			catch (Exception ex)
			{
				throw new ArgumentException("An error occured while trying to register", ex.Message);
			}
		
		}
	}
}
