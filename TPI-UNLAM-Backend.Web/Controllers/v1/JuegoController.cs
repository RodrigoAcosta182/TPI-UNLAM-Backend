using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TIP_UNLAM_Backend.Data.EF;
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

        [HttpGet("api/v1/auth")]
        public ActionResult<List<Juego>> autenticarUsuario()
        {
            return _juegoServicio.getAllJuegos();
        }

    }
}
