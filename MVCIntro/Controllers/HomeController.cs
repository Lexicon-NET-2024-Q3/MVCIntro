using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;
using System.Diagnostics;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string name ="Kalle")
        {
            TempData["Name"] = name;
            ViewBag.Name = name;

            var model = new List<string>() { "Hej", "på", "dig" };

            return View(nameof(Index), model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult GetValues()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult GetValues(string name, int salary)
        {
            return View(); 
        }

        public IActionResult GetValuesWithModel()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult GetValuesWithModel(Employee employee)
        {
            
            return View(); 
        }
    }
}
