﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TIP_UNLAM_Backend.Data.EF;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    public class JuegoController : Controller
    {

        private readonly IJuegoServicio _juegoServicio;

        public JuegoController(IJuegoServicio juegoServicio)
        {
            _juegoServicio = juegoServicio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("api/v1/getAllJuegos")]
        public ActionResult<List<Juego>> GetAllJuegos()
        {
            return _juegoServicio.getAllJuegos();
        }

        [HttpGet("api/v1/getAllColores")]
        public ActionResult<List<Colore>> GetAllColores()
        {
            return _juegoServicio.getAllColores();
        }

        [HttpPost("api/v1/ValidarCamposIguales")]
        public bool ValidarCamposIguales(string campo1, string campo2)
        {
            return _juegoServicio.validarStringIguales(campo1, campo2);
        }

        [HttpPost("api/v1/FinalizarJuego")]
        public void FinalizarJuego(ProgresosXusuarioXjuego juego)
        {
            _juegoServicio.FinalizarJuego(juego);
        }





    }
}
