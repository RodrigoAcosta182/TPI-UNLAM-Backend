using System;
using System.Collections.Generic;

#nullable disable

namespace Grandin.Web.EF
{
    public partial class Genero
    {
        public Genero()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
