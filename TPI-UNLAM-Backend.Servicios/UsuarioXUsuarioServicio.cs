using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Servicios
{
    public class UsuarioXUsuarioServicio : IUsuarioXUsuarioServicio
    {
        private IUsuarioXUsuarioRepositorio _userXuser;

        public UsuarioXUsuarioServicio(IUsuarioXUsuarioRepositorio userXuser)
        {
            _userXuser = userXuser;
        }
        public List<UsuarioXusuario> getPacienteXProfesionalInactivos(int UsuarioLogeadoId)
        {
            return _userXuser.getPacienteXProfesionalInactivos(UsuarioLogeadoId).ToList();
        }

        public List<UsuarioXusuario> getPacienteXProfesional(int UsuarioLogeadoId)
        {
            return _userXuser.getPacienteXProfesional(UsuarioLogeadoId).ToList();
        }
    }
}
