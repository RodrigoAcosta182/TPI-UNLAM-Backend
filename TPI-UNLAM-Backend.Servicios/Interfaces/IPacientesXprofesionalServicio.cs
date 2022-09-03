using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;

namespace TPI_UNLAM_Backend.Servicios.Interfaces
{
    public interface IPacientesXprofesionalServicio
    {
        public List<Paciente> getPacientesxProfesional(int idProfesional);
    }
}
