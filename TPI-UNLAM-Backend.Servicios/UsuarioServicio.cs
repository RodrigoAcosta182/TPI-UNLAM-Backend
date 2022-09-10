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
        private IUsuarioRepositorio _userRepo;

        public UsuarioServicio(IUsuarioRepositorio userRepo)
        {
            _userRepo = userRepo;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuario.FechaAlta = DateTime.Now;
            usuario.Activo = true;
            usuario.Matricula = "";

            if (usuario.TipoUsuario.Descripcion == "Paciente")
            {
                usuario.TipoUsuarioId = 1;
                
            }
            else
            {
                usuario.TipoUsuarioId = 2;
            }
            _userRepo.AgregarUsuario(usuario);
        }

        public void SaveChanges()
        {
            _userRepo.SaveChanges();
        }

        public Usuario getUsuarioByEmail(string email)
        {
            return _userRepo.getUsuarioByEmail(email);
        }

        public Usuario Login(string email, string clave)
        {
            Usuario usuario = new Usuario();
            if (email == null || clave == null)
                throw new Exception("Los datos ingresados incorrectos");

            usuario = _userRepo.getUsuarioByEmail(email);

            if (usuario == null)
                throw new Exception("Mail o clave incorrecta");

            if (usuario.Contrasena != clave)
                throw new Exception("Mail o clave incorrecta");

            return usuario;
        }
    }
}
