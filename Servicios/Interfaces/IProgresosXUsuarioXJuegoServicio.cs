using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.Dto;
using Grandin.Web.EF;

namespace TPI_UNLAM_Backend.Servicios.Interfaces
{
    public interface IProgresosXUsuarioXJuegoServicio
    {
        public List<vProgresosXUsuarioXJuego> getAllProgresoXPaciente();
        public List<vProgresosXUsuarioXJuego> getAllProgresoXProfesional();
        public List<vProgresosXUsuarioXJuego> getAllProgresoXPacienteXJuego(int juegoId);
        public List<vProgresosXUsuarioXJuego> getProgresoXPacienteXJuegoXProfesional(int pacienteId, int juegoid);
        public List<vProgresosXUsuarioXJuego> getProgresoXProfesionalXPaciente(int pacienteId);
        public List<vProgresosXUsuarioXJuego> getAllProgresoXJuego(int pacienteid, int juegoId);
        public void SaveChanges();
    }
}
