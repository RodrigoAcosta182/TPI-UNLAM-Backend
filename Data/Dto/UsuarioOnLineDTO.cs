using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIP_UNLAM_Backend.Data.Dto
{
    public class UsuarioOnLineDTO
    {
        [Required]
        public int userId { get; set; }
        [Required]
        public bool OnLine { get; set; }
    }
}
