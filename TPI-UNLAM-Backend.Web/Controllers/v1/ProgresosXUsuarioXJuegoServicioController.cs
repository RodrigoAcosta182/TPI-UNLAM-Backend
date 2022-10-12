using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        public ActionResult<List<ProgresosXusuarioXjuego>> getAllProgresoXPaciente()
        {
            return _progreso.getAllProgresoXPaciente();
        }

        [HttpGet("api/v1/ListaProgresosXPacienteById/{id}")]
        public ActionResult<List<ProgresosXusuarioXjuego>> getAllProgresoXPacienteById(int id)
        {
            return _progreso.getAllProgresoXPacienteById(id);
        }

        [HttpGet("api/v1/ProgresosXPacienteXJuego")]
        public ActionResult<ProgresosXusuarioXjuego> getAllProgresoXPacienteXJuego(int juegoId)
        {
            return _progreso.getAllProgresoXPacienteXJuego(juegoId);
        }

        [HttpGet("api/v1/ListaProgresosXProfesional")]
        public ActionResult<List<ProgresosXusuarioXjuego>> getAllProgresoXProfesional()
        {
            return _progreso.getAllProgresoXProfesional();
        }

        [HttpGet("api/v1/ProgresoXPacienteXJuegoXProfesional")]
        public ActionResult<ProgresosXusuarioXjuego> getProgresoXPacienteXJuegoXProfesional(Usuario paciente, int juegoid)
        {
            return _progreso.getProgresoXPacienteXJuegoXProfesional(paciente, juegoid);
        }

        [HttpGet("api/v1/ListaProgresoXProfesionalXPaciente")]
        public ActionResult<List<ProgresosXusuarioXjuego>> getProgresoXProfesionalXPaciente(Usuario paciente)
        {
            return _progreso.getProgresoXProfesionalXPaciente(paciente);
        }

    }
}
