namespace Vehycles.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using Vehycles.Models;

    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {

            await Task.CompletedTask;
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
