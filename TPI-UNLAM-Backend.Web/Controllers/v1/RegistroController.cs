using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TIP_UNLAM_Backend.Data.EF;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    public class RegistroController : Controller
    {

        private readonly IUsuarioServicio _usuarioServicio;

        public RegistroController(IUsuarioServicio usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("api/v1/auth")]
        public void agregarUsuario(Paciente pacientes)
        {
            _usuarioServicio.AgregarUsuarioPaciente(pacientes);
        }

    }
}
