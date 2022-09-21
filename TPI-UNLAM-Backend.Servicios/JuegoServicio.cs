using Microsoft.IdentityModel.SecurityTokenService;
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

        public List<Colore> getAllColores()
        {
            return _juegoRepo.getAllColores();
        }

        public List<Juego> getAllJuegos()
        {
            return _juegoRepo.getAllJuegos();
        }

        public Juego getJuegoById(int idJuego)
        {
            return _juegoRepo.getJuegoById(idJuego);
        }

        public bool validarStringIguales(string campo1, string campo2)
        {
            try
            {
                if (campo1 == null || campo2 == null)
                    throw new BadRequestException("No se enviaron los campos");

                if (campo1 == campo2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
