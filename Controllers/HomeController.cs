using System.Diagnostics;
using Actividad3LengProg3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Actividad3LengProg3.Controllers
{
    public class HomeController : Controller
    {

        private List<EstudianteViewModel> Estudiantes = new List<EstudianteViewModel>();

        public HomeController()
        {

        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista()
        {
            return View();
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

        public IActionResult Registrar(EstudianteViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.message = "El Estudiante fue registrado";
                return View(model);
            }

            return View(model);
        }
    }
}
