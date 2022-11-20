using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grandin.Web.EF;

namespace TPI_UNLAM_Backend.Servicios.Interfaces
{
    public interface IGeneroServicio
    {
        public List<Genero> getAllGeneros();
    }
}
