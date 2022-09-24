using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TIP_UNLAM_Backend.Data.EF;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioXUsuarioServicio _userService;

        public UsuarioController(IUsuarioXUsuarioServicio userService)
        {
            _userService = userService;
        }

        [HttpGet("api/v1/MisPacientes")]
        public ActionResult<List<UsuarioXusuario>> getPacienteXProfesional(int usuarioLogueado)
        {
            return _userService.getPacienteXProfesional(usuarioLogueado);
        }

    }
}
