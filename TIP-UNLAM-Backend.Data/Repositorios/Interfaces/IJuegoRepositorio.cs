using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;

namespace TIP_UNLAM_Backend.Data.Repositorios.Interfaces
{
    public interface IJuegoRepositorio
    {
        public List<Juego> getAllJuegos();
        public Juego getJuegoById(int idJuego);
    }
}
