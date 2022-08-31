using System;
using System.Collections.Generic;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class UsuarioXusuario
    {
        public int Id { get; set; }
        public int UsuarioId1 { get; set; }
        public int UsuarioId2 { get; set; }
        public DateTime FechaVinculacion { get; set; }
        public bool? Activo { get; set; }

        public virtual Usuario UsuarioId1Navigation { get; set; }
        public virtual Usuario UsuarioId2Navigation { get; set; }
    }
}
