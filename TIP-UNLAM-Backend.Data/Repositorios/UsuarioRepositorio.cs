using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;

namespace TIP_UNLAM_Backend.Data.Repositorios
{
    internal class UsuarioRepositorio : IUsuarioRepositorio
    {
        private TPI_UNLAM_DBContext _ctx;

        public UsuarioRepositorio(TPI_UNLAM_DBContext ctx)
        {
            _ctx = ctx;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            _ctx.Add(usuario);
        }



        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }

        public Usuario getUsuarioByEmail(string mail)
        {
            return _ctx.Usuarios.Where(x => x.Mail == mail).FirstOrDefault();
        }
    }
}
