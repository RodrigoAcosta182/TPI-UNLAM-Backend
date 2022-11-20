using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grandin.Web.EF;

namespace TPI_UNLAM_Backend.Servicios.Interfaces
{
    public interface IInformacionServicio
    {
        public List<Informacion> getAllInformacion();
        public Informacion getAllInformacionByDescripcion(string descripcion);
    }
}

