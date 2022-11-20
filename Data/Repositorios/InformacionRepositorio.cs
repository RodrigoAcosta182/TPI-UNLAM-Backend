using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grandin.Web.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;

namespace TIP_UNLAM_Backend.Data.Repositorios
{
    public class InformacionRepositorio : IInformacionRepositorio
    {
        private TPI_UNLAM_DB_Context _ctx;

        public InformacionRepositorio(TPI_UNLAM_DB_Context ctx)
        {
            _ctx = ctx;
        }
        public List<Informacion> getAllInformacion()
        {
            return _ctx.Informacions.ToList();
        }

        public Informacion getAllInformacionByDescripcion(string descripcion)
        {
            return _ctx.Informacions.Where(x => x.Descripcion == descripcion).FirstOrDefault();
        }
    }
}
