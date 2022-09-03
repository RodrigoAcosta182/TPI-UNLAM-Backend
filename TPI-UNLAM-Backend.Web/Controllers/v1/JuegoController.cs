using Microsoft.AspNetCore.Mvc;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    public class JuegoController : Controller
    {

        private readonly IJuegoServicio _juegoServicio;

        public JuegoController(IJuegoServicio juegoServicio)
        {
            _juegoServicio = juegoServicio;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
