﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TIP_UNLAM_Backend.Data.Dto;
using Grandin.Web.EF;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    [ApiController]
    public class NotasController : Controller
    {

        private readonly INotasServicio _notasServicio;

        public NotasController(INotasServicio notasServicio)
        {
            _notasServicio = notasServicio;
        }

        [HttpPost("api/v1/ArchivarNota")]
        public void ArchivarNota(int id)
        {
            _notasServicio.ArchivarNota(id);
        }
        [HttpPost("api/v1/GuardarNotaEnLlamada")]
        public void GuardarNotaEnLlamada([FromBody] Nota nota, string codigoLLamado)
        {
            _notasServicio.GuardarNotaEnLlamada(nota, codigoLLamado);
        }
        [HttpPost("api/v1/GuardarNota")]
        public void GuardarNota([FromBody] Nota nota)
        {
            _notasServicio.GuardarNota(nota);
        }
        [HttpGet("api/v1/GetAllNotasXPacienteXProfesional/{idPaciente}")]
        public ActionResult<List<Nota>> GetAllNotasXPacienteXProfesional(int idPaciente)
        {
            return _notasServicio.GetAllNotasXPacienteXProfesional(idPaciente);
        }
        [HttpGet("api/v1/GetAllNotasArchivadas")]
        public ActionResult<List<Nota>> GetAllNotasArchivadas()
        {
            return _notasServicio.getAllNotasArchivadas();
        }
    }
}
