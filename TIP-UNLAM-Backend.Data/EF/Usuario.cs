using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class Usuario
    {
        public Usuario()
        {
            ProgresosXusuarioXjuegoUsuarioPacientes = new HashSet<ProgresosXusuarioXjuego>();
            ProgresosXusuarioXjuegoUsuarioProfesionals = new HashSet<ProgresosXusuarioXjuego>();
            UsuarioXusuarioUsuarioPacientes = new HashSet<UsuarioXusuario>();
            UsuarioXusuarioUsuarioProfesionals = new HashSet<UsuarioXusuario>();
        }

        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Dni { get; set; }
        public string Matricula { get; set; }

        [Required]
        public string Contrasena { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }
        public int TipoUsuarioId { get; set; }

        [Required]
        public string Mail { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual ICollection<ProgresosXusuarioXjuego> ProgresosXusuarioXjuegoUsuarioPacientes { get; set; }
        public virtual ICollection<ProgresosXusuarioXjuego> ProgresosXusuarioXjuegoUsuarioProfesionals { get; set; }
        public virtual ICollection<UsuarioXusuario> UsuarioXusuarioUsuarioPacientes { get; set; }
        public virtual ICollection<UsuarioXusuario> UsuarioXusuarioUsuarioProfesionals { get; set; }
    }
}
