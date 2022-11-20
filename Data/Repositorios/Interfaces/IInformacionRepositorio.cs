using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grandin.Web.EF;

namespace TIP_UNLAM_Backend.Data.Repositorios.Interfaces
{
    public interface IInformacionRepositorio
    {
        public List<Informacion> getAllInformacion();
        public Informacion getAllInformacionByDescripcion(string descripcion);
    }
}
