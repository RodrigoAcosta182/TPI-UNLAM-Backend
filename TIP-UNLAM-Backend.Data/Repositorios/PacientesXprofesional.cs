using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;

namespace TIP_UNLAM_Backend.Data
{
    public class PacientesXprofesional : IPacientesXprofesional
    {
        private TPI_UNLAM_DBContext _ctx;

        public PacientesXprofesional(TPI_UNLAM_DBContext ctx)
        {
            _ctx = ctx;
        }

        public List<Paciente> getPacientesxProfesional(int idProfesional)
        {
            List<Paciente> pacientesProfesional = (List<Paciente>)(from pacientesPro in _ctx.PacientesXprofesionals
                                                      where pacientesPro.ProfesionalId == idProfesional
                                                      select pacientesPro);

            return pacientesProfesional;
        }
    }
}
