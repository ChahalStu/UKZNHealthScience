using ClinicalDocumentRepositorySystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClinicalDocumentRepositorySystem.Controllers
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
        public IActionResult Patient()
        {

            return View();
        
        }
        public IActionResult Clinic()
        {

            return View();

        }
        public IActionResult UserAdmin()
        {

            return View();

        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ManageUserClinics()
        {
            return View();
        }
        public IActionResult ManageUserPermissions()
        {
            return View();
        }

        public IActionResult PatientRecords()
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
