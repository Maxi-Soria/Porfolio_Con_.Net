using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                titulo = "Primer proyectp",
                descripcion = "Descripcion del proy inventado",
                link = "proyecto.com",
                imagenUrl = "/imagenes/descarga1.jpg"
            },
                new Proyecto
            {
                titulo = "Segundo proyecto",
                descripcion = "Descripcion del segundo proyecto",
                link = "proyecto.com",
                imagenUrl = "/imagenes/descarga1.jpg"
            },
                new Proyecto
            {
                titulo = "Tercer proyecto",
                descripcion = "Descripcion del tercer proyecto",
                link = "proyecto.com",
                imagenUrl = "/imagenes/descarga3.jpg"
            },
                new Proyecto
            {
                titulo = "Cuarto proyecto",
                descripcion = "Descripcion del cuarto proyecto",
                link = "proyecto.com",
                imagenUrl = "/imagenes/descarga4.jpg"
            },

            };
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
