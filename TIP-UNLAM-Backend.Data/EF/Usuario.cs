using System;
using System.Collections.Generic;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class Usuario
    {
        public Usuario()
        {
            UsuarioXusuarioUsuarioId1Navigations = new HashSet<UsuarioXusuario>();
            UsuarioXusuarioUsuarioId2Navigations = new HashSet<UsuarioXusuario>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; set; }

        public virtual ICollection<UsuarioXusuario> UsuarioXusuarioUsuarioId1Navigations { get; set; }
        public virtual ICollection<UsuarioXusuario> UsuarioXusuarioUsuarioId2Navigations { get; set; }
    }
}
