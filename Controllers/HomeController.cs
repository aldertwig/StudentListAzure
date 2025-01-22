using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentListMVC.Data;
using StudentListMVC.Models;

namespace StudentListMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;
        private readonly IStudent _studentRepository;
        public HomeController(ILogger<HomeController> logger, IConfiguration config, IStudent studentRepository)
        {
            _logger = logger;
            _config = config;
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            return View(_studentRepository.GetAll());
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
