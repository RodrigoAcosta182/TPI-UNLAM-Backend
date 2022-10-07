using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TIP_UNLAM_Backend.Data.EF;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioXUsuarioServicio _userService;
        private readonly IUsuarioServicio _userServi;

        public UsuarioController(IUsuarioXUsuarioServicio userService, IUsuarioServicio userServi)
        {
            _userService = userService;
            _userServi = userServi;
        }

        [HttpGet("api/v1/MisPacientes")]
        public ActionResult<List<UsuarioXusuario>> getPacienteXProfesional(int usuarioLogueado)
        {
            return _userService.getPacienteXProfesional(usuarioLogueado);
        }

        [HttpGet("api/v1/MisPacientes")]
        public ActionResult<List<Usuario>> getAllProfesionales()
        {
            return _userServi.getAllUsuariosProfesionales();
        }


        [HttpGet("api/v1/ObtenerUsuario")]
        public Usuario getUsuario(int id)
        {
            return _userServi.getUsuarioById(id);
        }

        [HttpPost("api/v1/ModificarUsuario")]
        public void ModificarUsuario(Usuario usuario)
        {
            _userServi.modificarUsuario(usuario);        
        }

    }
}
