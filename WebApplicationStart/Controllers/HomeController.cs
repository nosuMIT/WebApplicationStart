using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Tasks()
        {
            return View();
        }

        public string Task1()
        {
            DateTime time = DateTime.Now;
            string result = "";

            if (time.Hour >= 0 && time.Hour < 6)
            {
                result = "Доброй ночи";
            }
            else if (time.Hour >= 6 && time.Hour < 12)
            {
                result = "Доброе утро";
            }
            else if (time.Hour >= 12 && time.Hour < 18)
            {
                result = "Добрый день";
            }
            else
            {
                result = "Добрый вечер";
            }

            return result;
        }

        public string Task2(int a, int b)
        {
            return a + " + " + b + " = " + (a + b);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}