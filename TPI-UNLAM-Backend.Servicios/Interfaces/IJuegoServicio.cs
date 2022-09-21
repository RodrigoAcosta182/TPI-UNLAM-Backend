using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;

namespace TPI_UNLAM_Backend.Servicios.Interfaces
{
    public interface IJuegoServicio
    {
        public List<Juego> getAllJuegos();
        public Juego getJuegoById(int idJuego);
        public List<Colore> getAllColores();
        public bool validarStringIguales(string campo1, string campo2);
    }
}
