using Microsoft.AspNetCore.Mvc;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioServicio _usuarioServicio;

        public UsuarioController(IUsuarioServicio usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
