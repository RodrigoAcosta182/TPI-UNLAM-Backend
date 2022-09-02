using System;
using System.Collections.Generic;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class ProgresosXpacientesXjuego
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int ProfesionalId { get; set; }
        public int JuegoId { get; set; }
        public DateTime FechaInicioJuego { get; set; }
        public DateTime FechaFinalizacionJuego { get; set; }
        public bool Finalizado { get; set; }
        public short Aciertos { get; set; }
        public short Fallos { get; set; }

        public virtual Juego Juego { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Profesionale Profesional { get; set; }
    }
}
