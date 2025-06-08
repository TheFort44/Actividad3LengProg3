using Microsoft.AspNetCore.Mvc;

namespace Actividad3LengProg3.Controllers
{
    public class EstudianteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }
    }
}
