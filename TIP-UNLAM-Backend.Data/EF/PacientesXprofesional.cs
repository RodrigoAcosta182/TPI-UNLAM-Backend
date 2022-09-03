using System;
using System.Collections.Generic;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class PacientesXprofesional
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int ProfesionalId { get; set; }
        public DateTime FechaInicioContacto { get; set; }
        public DateTime FechaFinalizacionContacto { get; set; }
        public bool Activo { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual Profesionale Profesional { get; set; }
    }
}
