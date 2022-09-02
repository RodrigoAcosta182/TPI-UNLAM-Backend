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
    public class UsuarioServicio : IUsuarioServicio
    {
        private IUsuarioRepositorio _usuarioRepo;

        public UsuarioServicio(IUsuarioRepositorio usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        public Usuario GetUsuarioById(int idUsuario)
        {
           return _usuarioRepo.GetUsuarioById(idUsuario);
        }

        public void GuardarUsuario(Usuario usuario)
        {
            if (_usuarioRepo.GetUsuarioByMailExistente(usuario) == true)
                throw new Exception("El usuario ya existe");

            _usuarioRepo.GuardarUsuario(usuario);
            _usuarioRepo.SaveChanges();
        }

        public void SaveChanges()
        {
            _usuarioRepo.SaveChanges();
        }
    }
}
