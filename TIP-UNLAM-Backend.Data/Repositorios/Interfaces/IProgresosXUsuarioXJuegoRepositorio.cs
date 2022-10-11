using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;

namespace TIP_UNLAM_Backend.Data.Repositorios.Interfaces
{
    public interface IProgresosXUsuarioXJuegoRepositorio
    {
        public List<ProgresosXusuarioXjuego> getAllProgresoXPaciente(Usuario paciente);
        public List<ProgresosXusuarioXjuego> getAllProgresoXProfesional(Usuario Profesional);
        public ProgresosXusuarioXjuego getAllProgresoXPacienteXJuego(Usuario paciente, int juegoId);
        public ProgresosXusuarioXjuego getProgresoXPacienteXJuegoXProfesional(Usuario paciente, int juegoId, Usuario profesional);
        public List<ProgresosXusuarioXjuego> getProgresoXProfesionalXPaciente(Usuario paciente, Usuario profesional);
        public void SaveChanges();
    }
}
