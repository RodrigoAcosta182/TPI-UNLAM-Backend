using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;

namespace TIP_UNLAM_Backend.Data
{
    public class UsuarioXUsuarioRepositorio : IUsuarioXUsuarioRepositorio
    {
        private TPI_UNLAM_DB_Context _ctx;

        public UsuarioXUsuarioRepositorio(TPI_UNLAM_DB_Context ctx)
        {
            _ctx = ctx;
        }

        public List<UsuarioXusuario> getPacienteXProfesional(int UsuarioLogeadoId)
        {
            return _ctx.UsuarioXusuarios.Where(x => x.UsuarioProfesionalId == UsuarioLogeadoId).ToList();
        }

        public List<UsuarioXusuario> getPacienteXProfesionalInactivos(int UsuarioLogeadoId)
        {
            return _ctx.UsuarioXusuarios.Where(x => x.UsuarioProfesionalId == UsuarioLogeadoId && x.Activo == false).ToList();
        }

        public List<UsuarioXusuario> getPacienteXProfesionalActivos(int UsuarioLogeadoId)
        {
            return _ctx.UsuarioXusuarios.Where(x => x.UsuarioProfesionalId == UsuarioLogeadoId && x.Activo == true).ToList();
        }
        public UsuarioXusuario HabilitarPacienteXProfesional(int UsuarioLogeadoId, int pacienteId)
        {
            return _ctx.UsuarioXusuarios.Where(x => x.UsuarioProfesionalId == UsuarioLogeadoId && x.UsuarioPacienteId == pacienteId).FirstOrDefault();
        }

        public UsuarioXusuario getProfesionalXPaciente (int UsuarioLogeadoId)
        {
            return _ctx.UsuarioXusuarios.Where(x => x.UsuarioPacienteId == UsuarioLogeadoId && x.Activo == true).FirstOrDefault();
        }

        public void agregarRelacion(UsuarioXusuario usuarioxusuario)
        {
            _ctx.Add(usuarioxusuario);
        }
        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }



    }
}
