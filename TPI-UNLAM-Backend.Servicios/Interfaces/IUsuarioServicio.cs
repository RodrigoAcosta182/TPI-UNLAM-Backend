using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.Dto;
using TIP_UNLAM_Backend.Data.EF;

namespace TPI_UNLAM_Backend.Servicios.Interfaces
{
    public interface IUsuarioServicio
    {
        public string AgregarUsuario(Usuario usuario);
        public Usuario getUsuarioByEmail(string email);
        public Usuario getUsuarioById(int id);
        public UsuarioDto Login(LoginDto loginDto);
        public void SaveChanges();
        public void modificarUsuario(Usuario usuario);
    }
}
