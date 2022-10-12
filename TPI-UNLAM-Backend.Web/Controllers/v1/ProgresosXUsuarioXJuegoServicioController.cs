using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TIP_UNLAM_Backend.Data.Dto;
using TIP_UNLAM_Backend.Data.EF;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    public class ProgresosXUsuarioXJuegoServicioController : Controller
    {
        private readonly IUsuarioXUsuarioServicio _userService;
        private readonly IUsuarioServicio _userServi;
        private readonly IProgresosXUsuarioXJuegoServicio _progreso;

        public ProgresosXUsuarioXJuegoServicioController(IUsuarioXUsuarioServicio userService, IUsuarioServicio userServi, IProgresosXUsuarioXJuegoServicio progreso)
        {
            _userService = userService;
            _userServi = userServi;
            _progreso = progreso;
        }

        [HttpGet("api/v1/ListaProgresosXPaciente")]
        public ActionResult<List<vProgresosXUsuarioXJuego>> getAllProgresoXPaciente()
        {
            return _progreso.getAllProgresoXPaciente();
        }

        [HttpGet("api/v1/ProgresosXPacienteXJuego")]
        public ActionResult<vProgresosXUsuarioXJuego> getAllProgresoXPacienteXJuego(int juegoId)
        {
            return _progreso.getAllProgresoXPacienteXJuego(juegoId);
        }

        [HttpGet("api/v1/ListaProgresosXProfesional")]
        public ActionResult<List<vProgresosXUsuarioXJuego>> getAllProgresoXProfesional()
        {
            return _progreso.getAllProgresoXProfesional();
        }

        [HttpGet("api/v1/ProgresoXPacienteXJuegoXProfesional")]
        public ActionResult<vProgresosXUsuarioXJuego> getProgresoXPacienteXJuegoXProfesional(Usuario paciente, int juegoid)
        {
            return _progreso.getProgresoXPacienteXJuegoXProfesional(paciente, juegoid);
        }

        [HttpGet("api/v1/ListaProgresoXProfesionalXPaciente")]
        public ActionResult<List<vProgresosXUsuarioXJuego>> getProgresoXProfesionalXPaciente(Usuario paciente)
        {
            return _progreso.getProgresoXProfesionalXPaciente(paciente);
        }

    }
}
