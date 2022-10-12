using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.Dto;
using TIP_UNLAM_Backend.Data.EF;

namespace TIP_UNLAM_Backend.Data.Repositorios.Interfaces
{
    public interface IProgresosXUsuarioXJuegoRepositorio
    {
        public List<vProgresosXUsuarioXJuego> getAllProgresoXPaciente(Usuario paciente);
        public List<vProgresosXUsuarioXJuego> getAllProgresoXProfesional(Usuario Profesional);
        public vProgresosXUsuarioXJuego getAllProgresoXPacienteXJuego(Usuario paciente, int juegoId);
        public vProgresosXUsuarioXJuego getProgresoXPacienteXJuegoXProfesional(Usuario paciente, int juegoId, Usuario profesional);
        public List<vProgresosXUsuarioXJuego> getProgresoXProfesionalXPaciente(Usuario paciente, Usuario profesional);
        public void SaveChanges();
    }
}
