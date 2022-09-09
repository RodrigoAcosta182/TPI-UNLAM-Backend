using System;
using System.Collections.Generic;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class Usuario
    {
        public Usuario()
        {
            UsuarioXusuarioUsuarioPacientes = new HashSet<UsuarioXusuario>();
            UsuarioXusuarioUsuarioProfesionals = new HashSet<UsuarioXusuario>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apeliido { get; set; }
        public string Dni { get; set; }
        public string Matricula { get; set; }
        public string Mail { get; set; }
        public string Contrasena { get; set; }
        public int TipoUsuarioId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual ICollection<UsuarioXusuario> UsuarioXusuarioUsuarioPacientes { get; set; }
        public virtual ICollection<UsuarioXusuario> UsuarioXusuarioUsuarioProfesionals { get; set; }
    }
}
