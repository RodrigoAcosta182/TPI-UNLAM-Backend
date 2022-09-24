﻿using ArPortalTurnos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;

namespace TIP_UNLAM_Backend.Data.Dto
{
    public class UsuarioDto
    {
        public Usuario usuario { get; set; }
        public UserTokenDto token { get; set; }
    }
}
