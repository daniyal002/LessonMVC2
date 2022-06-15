using LessonMVC2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LessonMVC2.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly ProductRepository productRepository;
        public HomeController()
        {
            productRepository = new ProductRepository();
        }


        public IActionResult Index()
        {
            var products = productRepository.GetAll();
            return View(products);
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
