﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;

namespace TIP_UNLAM_Backend.Data.Repositorios
{
    public class JuegoRepositorio : IJuegoRepositorio
    {
        private TPI_UNLAM_DBContext _ctx;

        public JuegoRepositorio(TPI_UNLAM_DBContext ctx)
        {
            _ctx = ctx;
        }

        public List<Juego> getAllJuegos()
        {
            return _ctx.Juegos.OrderBy(x => x.Codigo).ToList();
        }

        public Juego getJuegoById(int idJuego)
        {
            return _ctx.Juegos.Find(idJuego);
        }
    }
}
