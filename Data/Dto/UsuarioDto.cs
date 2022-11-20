using TPI_UNLAM_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grandin.Web.EF;

namespace TIP_UNLAM_Backend.Data.Dto
{
    public class UsuarioDto
    {
        public Usuario usuario { get; set; }
        public string token { get; set; }
        public int usuarioProfesionalId { get; set; }
    }
}
