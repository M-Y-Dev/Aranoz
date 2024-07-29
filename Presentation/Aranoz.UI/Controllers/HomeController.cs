using Aranoz.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aranoz.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //test test

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {   
            //test 12345
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
