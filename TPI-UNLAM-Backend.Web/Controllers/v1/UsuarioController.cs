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

        #region get
        [HttpGet("api/v1/MisPacientes")]
        public ActionResult<List<UsuarioXusuario>> getPacienteXProfesional(int usuarioLogueado)
        {
            return _userService.getPacienteXProfesional(usuarioLogueado);
        }

        [HttpGet("api/v1/MisPacientesInactivos")]
        public ActionResult<List<UsuarioXusuario>> getPacienteXProfesionalInactivos(int usuarioLogueado)
        {
            return _userService.getPacienteXProfesionalInactivos(usuarioLogueado);
        }

        [HttpGet("api/v1/GetAllProfesionalesActivos")]
        public ActionResult<List<Usuario>> getAllProfesionales()
        {
            return _userServi.getAllUsuariosProfesionalesActivos();
        }

        [HttpGet("api/v1/GetAllProfesionales")]
        public ActionResult<List<Usuario>> getAllProfesionalesInactivos()
        {
            return _userServi.getAllUsuariosProfesionalesInactivos();
        }

        [HttpGet("api/v1/ObtenerUsuario")]
        public Usuario getUsuario(int id)
        {
            return _userServi.getUsuarioById(id);
        }
        #endregion

        #region post
        [HttpPost("api/v1/ModificarUsuario")]
        public void ModificarUsuario(Usuario usuario)
        {
            _userServi.modificarUsuario(usuario);
        }

        [HttpPost("api/v1/HabilitarProfesional")]
        public void HabilitarProfesional(int id, bool estado)
        {
            _userServi.HabilitarProfesional(id);
        }
        #endregion




    }
}
