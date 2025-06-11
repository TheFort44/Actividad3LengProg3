using Actividad3LengProg3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace Actividad3LengProg3.Controllers
{

    public class HomeController : Controller
    {

        private static List<EstudianteViewModel> estudiantes = new List<EstudianteViewModel>();

        private readonly List<string> carreras = new List<string> { "Ingeniería", "Medicina", "Derecho", "Arquitectura" };
        private readonly List<string> tiposIngreso = new List<string> { "Nuevo ingreso", "Reingreso", "Transferencia" };

        [HttpGet]
        public IActionResult Index()
        {
            CargarCombos();
            return View(new EstudianteViewModel());
        }

        [HttpPost]
        public IActionResult Registrar(EstudianteViewModel model)
        {
            CargarCombos();

            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            estudiantes.Add(model);
            TempData["Mensaje"] = "Estudiante registrado correctamente.";
            return RedirectToAction("ListadoEstudiantes");
        }


        public IActionResult ListadoEstudiantes()
        {
            return View(estudiantes);
        }


        private void CargarCombos()
        {
            ViewBag.Carreras = new SelectList(carreras);
            ViewBag.TiposIngreso = new SelectList(tiposIngreso);
        }
    }
}
