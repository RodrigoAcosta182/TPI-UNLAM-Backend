using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;

namespace TIP_UNLAM_Backend.Data.Repositorios
{
    public class ProgresosXUsuarioXJuegoRepositorio : IProgresosXUsuarioXJuegoRepositorio
    {
        private TPI_UNLAM_DB_Context _ctx;

        public ProgresosXUsuarioXJuegoRepositorio(TPI_UNLAM_DB_Context ctx)
        {
            _ctx = ctx;
        }

        public List<ProgresosXusuarioXjuego> getAllProgresoXPaciente(Usuario paciente)
        {
            return _ctx.ProgresosXusuarioXjuegos.Where(x => x.UsuarioId == paciente.Id).ToList();
        }

        public List<ProgresosXusuarioXjuego> getAllProgresoXProfesional(Usuario Profesional)
        {
            return _ctx.ProgresosXusuarioXjuegos.Where(x => x.ProfesionalId == Profesional.Id).ToList();
        }

        public ProgresosXusuarioXjuego getAllProgresoXPacienteXJuego(Usuario paciente, int juegoId)
        {
            return _ctx.ProgresosXusuarioXjuegos.Where(x => x.UsuarioId == paciente.Id &&  x.JuegoId == juegoId).FirstOrDefault();
        }

        public ProgresosXusuarioXjuego getProgresoXPacienteXJuegoXProfesional(Usuario paciente, int juegoId, Usuario profesional)
        {
            return _ctx.ProgresosXusuarioXjuegos.Where(x => x.UsuarioId == paciente.Id && x.JuegoId == juegoId && x.ProfesionalId == profesional.Id).FirstOrDefault();
        }

        public List<ProgresosXusuarioXjuego> getProgresoXProfesionalXPaciente(Usuario paciente, Usuario profesional)
        {
            return _ctx.ProgresosXusuarioXjuegos.Where(x => x.UsuarioId == paciente.Id && x.ProfesionalId == profesional.Id).ToList();
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }

    }
}
