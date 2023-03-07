using Microsoft.AspNetCore.Mvc;
using MvcRoutingAttributesApp.Models;
using System.Diagnostics;

namespace MvcRoutingAttributesApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("{name:alpha:minlength(3)}/{age:int = 100}")]
        public IActionResult UserInfo(string name, int age)
        {
            return Content($"User info: {name}, {age}");
        }

        [Route("Home/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}