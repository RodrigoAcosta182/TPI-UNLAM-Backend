using System;
using System.Collections.Generic;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class Paise
    {
        public Paise()
        {
            Pacientes = new HashSet<Paciente>();
            Profesionales = new HashSet<Profesionale>();
            Provincia = new HashSet<Provincia>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
        public virtual ICollection<Profesionale> Profesionales { get; set; }
        public virtual ICollection<Provincia> Provincia { get; set; }
    }
}
