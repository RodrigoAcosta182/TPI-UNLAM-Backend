using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TIP_UNLAM_Backend.Data.EF;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    [ApiController]
    public class RegistroController : Controller
    {

        private readonly IUsuarioServicio _usuarioServicio;

        public RegistroController(IUsuarioServicio usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }

        [HttpPost("api/v1/agregarUsuario")]
        public string agregarUsuario([FromBody] Usuario usuario)
        {

            if (_usuarioServicio.AgregarUsuario(usuario) == true)
                return "El usuario se registro correctamente";

            return "No se pudo registrar el usuario";
                    
        }
    }
}
