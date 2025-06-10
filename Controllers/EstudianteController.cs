using Actividad3LengProg3.Models;
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

        [HttpPost]
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
