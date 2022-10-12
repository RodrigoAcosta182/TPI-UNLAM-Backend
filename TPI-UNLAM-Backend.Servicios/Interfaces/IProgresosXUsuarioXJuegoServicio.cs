using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;

namespace TPI_UNLAM_Backend.Servicios.Interfaces
{
    public interface IProgresosXUsuarioXJuegoServicio
    {
        public List<ProgresosXusuarioXjuego> getAllProgresoXPaciente();
        public List<ProgresosXusuarioXjuego> getAllProgresoXPacienteById(int id);
        public List<ProgresosXusuarioXjuego> getAllProgresoXProfesional();
        public ProgresosXusuarioXjuego getAllProgresoXPacienteXJuego(int juegoId);
        public ProgresosXusuarioXjuego getProgresoXPacienteXJuegoXProfesional(Usuario paciente, int juegoid);

        public List<ProgresosXusuarioXjuego> getProgresoXProfesionalXPaciente(Usuario paciente);
        public void SaveChanges();
    }
}
