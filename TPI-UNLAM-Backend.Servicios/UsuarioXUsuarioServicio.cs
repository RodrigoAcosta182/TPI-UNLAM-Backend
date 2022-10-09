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
        private IAppSharedFunction _appSharedFunction;
        private IUsuarioRepositorio _userRepo;
        public UsuarioXUsuarioServicio(IUsuarioXUsuarioRepositorio userXuser, IAppSharedFunction appSharedFunction, IUsuarioRepositorio userRepo)
        {
            _userXuser = userXuser;
            _appSharedFunction = appSharedFunction;
            _userRepo = userRepo;
        }

        public List<UsuarioXusuario> getPacienteXProfesional()
        {
            string email = _appSharedFunction.GetUsuarioPorToken();
            Usuario usuario = _userRepo.getUsuarioByEmail(email);
            return _userXuser.getPacienteXProfesional(usuario.Id).ToList();
        }

        public List<UsuarioXusuario> getPacienteXProfesionalActivos()
        {
            string email = _appSharedFunction.GetUsuarioPorToken();
            Usuario usuario = _userRepo.getUsuarioByEmail(email);
            return _userXuser.getPacienteXProfesionalActivos(usuario.Id).ToList();
        }

        public List<UsuarioXusuario> getPacienteXProfesionalInactivos()
        {
            string email = _appSharedFunction.GetUsuarioPorToken();
            Usuario usuario = _userRepo.getUsuarioByEmail(email);
            return _userXuser.getPacienteXProfesionalInactivos(usuario.Id).ToList();
        }
    }
}
