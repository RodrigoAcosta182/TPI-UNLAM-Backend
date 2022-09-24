using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArPortalTurnos.Models
{
    public class UserTokenDto
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
