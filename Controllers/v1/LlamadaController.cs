using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.Dto;
using Grandin.Web.EF;
using TPI_UNLAM_Backend.Hubs;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    
    [ApiController]
    public class LlamadaController : ControllerBase
    {
        private IHubContext<MessageHub> _hubContext;
        private ILlamadaServicio _llamadaServicio;

        public LlamadaController (IHubContext<MessageHub> hubContext, ILlamadaServicio llamadaServicio)
        {
            _hubContext = hubContext;
            _llamadaServicio = llamadaServicio;
        }


        [HttpPost("api/v1/llamadaSaliente")]
        public async Task<IActionResult> llamadaSaliente([FromBody] MensajeLlamadaDto llamadaDto)
        {
            await _hubContext.Clients.Group(llamadaDto.ReceptorId).SendAsync("sendMessage", llamadaDto);
            return Ok();
        }

        [HttpPost("api/v1/guardarLlamada")]
        public void GuardarLlamada([FromBody] LlamadaDto llamada)
        {
            _llamadaServicio.GuardarLlamada(llamada);
        }

        [HttpGet("api/v1/obtenerLlamadaActual")]
        public LlamadaDto obtenerLlamadaActual()
        {
            return _llamadaServicio.obtenerLlamadaActual();
        }

        [HttpPost("api/v1/estadoConexion")]
        public async Task<IActionResult> estadoConexion([FromBody] EstadoConexionDto conexion)
        {
            await _hubContext.Clients.Group(conexion.emailProfesional).SendAsync("estadoConexion", conexion);
            return Ok();
        }



    }
}
