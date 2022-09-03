using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Servicios
{
    public class PacientesXprofesionalServicio : IPacientesXprofesionalServicio
    {
        private IPacientesXprofesional _propaRepo;
        public PacientesXprofesionalServicio(IPacientesXprofesional propaRepo)
        {
            _propaRepo = propaRepo;
        }

        public List<Paciente> getPacientesxProfesional(int idProfesional)
        {
            return _propaRepo.getPacientesxProfesional(idProfesional);
        }
    }
}
