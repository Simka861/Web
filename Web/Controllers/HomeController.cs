using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
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
        public IActionResult Start()
        {
            Random random = new Random();
            char[,] array = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int r = random.Next(0, 3);
                    switch (r)
                    {
                        case 0:
                            array[i, j] = ' ';
                            break;
                        case 1:
                            array[i, j] = 'x';
                            break;
                        case 2:
                            array[i, j] = 'o';
                            break;
                    }
                }
            }
            return View(array);
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
    }
}