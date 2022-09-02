using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;

namespace TIP_UNLAM_Backend.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private TPI_UNLAM_DBContext _ctx;

        public UsuarioRepositorio(TPI_UNLAM_DBContext ctx)
        {
            _ctx = ctx;                
        }

        public Usuario GetUsuarioById(int idUsuario)
        {
            return _ctx.Usuarios.Find(idUsuario);
        }

        public void GuardarUsuario(Usuario usuario)
        {
            _ctx.Usuarios.Add(usuario);
        }

        public bool GetUsuarioByMailExistente(Usuario user)
        {
            if (_ctx.Usuarios.Where(x => x.Dni == user.Dni) != null)
                return true;
            
            return false;
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }
}
