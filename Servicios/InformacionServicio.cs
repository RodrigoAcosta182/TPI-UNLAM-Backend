using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grandin.Web.EF;
using Microsoft.IdentityModel.SecurityTokenService;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Servicios
{
    public class InformacionServicio : IInformacionServicio
    {
        private IInformacionRepositorio _infoRepo;

        private IAppSharedFunction _appSharedFunction;

        public InformacionServicio(IInformacionRepositorio infoRepo, IAppSharedFunction appSharedFunction)
        {
            _infoRepo = infoRepo;
            _appSharedFunction = appSharedFunction;
        }
   

        public List<Informacion> getAllInformacion()
        {
            return _infoRepo.getAllInformacion();
        }

        public Informacion getAllInformacionByDescripcion(string descripcion)
        {
            if (String.IsNullOrEmpty(descripcion) )
                throw new BadRequestException("No se envio la descripcion");

            return _infoRepo.getAllInformacionByDescripcion(descripcion);
        }
    }
}
