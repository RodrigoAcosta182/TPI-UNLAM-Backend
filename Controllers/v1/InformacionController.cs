using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grandin.Web.EF;
using TPI_UNLAM_Backend.Servicios;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    [ApiController]
    public class InformacionController : Controller
    {
        private readonly IInformacionServicio _InfoServicio;

        public InformacionController(IInformacionServicio InfoServicio)
        {
            _InfoServicio = InfoServicio;
        }

        [HttpGet("api/v1/getAllInformacion")]
        public ActionResult<List<Informacion>> getAllInformacion()
        {
            return _InfoServicio.getAllInformacion();
        }

        [HttpGet("api/v1/getAllInformacionByDescripcion")]
        public ActionResult<Informacion> getAllInformacionByDescripcion(string descripcion)
        {
            return _InfoServicio.getAllInformacionByDescripcion(descripcion);
        }
    }
}
