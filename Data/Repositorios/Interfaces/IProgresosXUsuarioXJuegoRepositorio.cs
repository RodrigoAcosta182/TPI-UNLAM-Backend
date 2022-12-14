using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.Dto;
using Grandin.Web.EF;

namespace TIP_UNLAM_Backend.Data.Repositorios.Interfaces
{
    public interface IProgresosXUsuarioXJuegoRepositorio
    {
        public List<vProgresosXUsuarioXJuego> getAllProgresoXPaciente(Usuario paciente);
        public List<vProgresosXUsuarioXJuego> getAllProgresoXProfesional(Usuario Profesional);
        public List<vProgresosXUsuarioXJuego> getAllProgresoXPacienteXJuego(Usuario paciente, int juegoId);
        public List<vProgresosXUsuarioXJuego> getProgresoXPacienteXJuegoXProfesional(int pacienteId, int juegoId, Usuario profesional);
        public List<vProgresosXUsuarioXJuego> getProgresoXProfesionalXPaciente(int pacienteId, Usuario profesional);
        public List<vProgresosXUsuarioXJuego> getAllProgresoXJuego(int pacienteId, int juegoId);
        public void SaveChanges();
    }
}
