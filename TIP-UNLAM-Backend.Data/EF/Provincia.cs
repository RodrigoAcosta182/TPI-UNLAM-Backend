using System;
using System.Collections.Generic;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class Provincia
    {
        public Provincia()
        {
            Pacientes = new HashSet<Paciente>();
            Profesionales = new HashSet<Profesionale>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? PaisId { get; set; }

        public virtual Paise Pais { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
        public virtual ICollection<Profesionale> Profesionales { get; set; }
    }
}
