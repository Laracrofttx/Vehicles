using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using Vehycle.Web.ViewModels.Account;
using Vehycles.Services.Interfaces;
using static Vehycle.Common.EntityValidationConstants;

namespace Vehycles.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
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
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("An error occured while trying to register", ex.Message);
            }
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginRequestModel model)
        {
            if (!ModelState.IsValid) { return BadRequest("Something went wrong. Try again later."); }
           
            try
            {
                var result = await this.userService.LoginAsync(model);
                return View(result);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
