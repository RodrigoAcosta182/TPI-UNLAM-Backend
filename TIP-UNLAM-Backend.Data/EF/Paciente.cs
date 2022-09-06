using System;
using System.Collections.Generic;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class Paciente
    {
        public Paciente()
        {
            PacientesXprofesionals = new HashSet<PacientesXprofesional>();
            ProgresosXpacientesXjuegos = new HashSet<ProgresosXpacientesXjuego>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; set; }
        public int ProvinciaId { get; set; }
        public int PaisId { get; set; }

        public virtual Paise Pais { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<PacientesXprofesional> PacientesXprofesionals { get; set; }
        public virtual ICollection<ProgresosXpacientesXjuego> ProgresosXpacientesXjuegos { get; set; }


    }
}
