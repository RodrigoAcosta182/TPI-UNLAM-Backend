using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Servicios
{
    public class JuegoServicio : IJuegoServicio
    {
        private IJuegoRepositorio _juegoRepo;

        public JuegoServicio(IJuegoRepositorio juegoRepo)
        {
            _juegoRepo = juegoRepo;
        }

        public List<Juego> getAllJuegos()
        {
           return _juegoRepo.getAllJuegos();
        }
    }
}
