﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TIP_UNLAM_Backend.Data.EF;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Controllers.v1
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioXUsuarioServicio _userService;
        private readonly IUsuarioServicio _userServi;

        public UsuarioController(IUsuarioXUsuarioServicio userService, IUsuarioServicio userServi)
        {
            _userService = userService;
            _userServi = userServi;
        }

        #region get
        [HttpGet("api/v1/MisPacientes")]
        public ActionResult<List<UsuarioXusuario>> getPacienteXProfesional()
        {
            return _userService.getPacienteXProfesional();
        }
        [HttpGet("api/v1/MisPacientesActivos")]
        public ActionResult<List<UsuarioXusuario>> getPacienteXProfesionalActivos()
        {
            return _userService.getPacienteXProfesionalActivos();
        }
        [HttpGet("api/v1/MisPacientesInactivos")]
        public ActionResult<List<UsuarioXusuario>> getPacienteXProfesionalInactivos()
        {
            return _userService.getPacienteXProfesionalInactivos();
        }

        [HttpGet("api/v1/ObtenerUsuario")]
        public Usuario getUsuario(int id)
        {
            return _userServi.getUsuarioById(id);
        }

        [HttpGet("api/v1/ObtenerTodosLosProfesionales")]
        public ActionResult<List<Usuario>> getAllProfesionales()
        {
            return _userServi.getAllUsuariosProfesionales();
        }

        [HttpGet("api/v1/ObtenerTodosLosProfesionalesActivos")]
        public ActionResult<List<Usuario>> getAllProfesionalesActivos()
        {
            return _userServi.getAllUsuariosProfesionalesActivos();
        }

        [HttpGet("api/v1/ObtenerTodosLosProfesionalesInactivos")]
        public ActionResult<List<Usuario>> getAllProfesionalesInactivos()
        {
            return _userServi.getAllUsuariosProfesionalesInactivos();
        }

        [HttpGet("api/v1/ObtenerTodosLosPacientes")]
        public ActionResult<List<Usuario>> getAllPacientes()
        {
            return _userServi.getAllUsuariosPacientes();
        }

        [HttpGet("api/v1/ObtenerTodosLosPacientesActivos")]
        public ActionResult<List<Usuario>> getAllUsuariosPacientesActivos()
        {
            return _userServi.getAllUsuariosProfesionalesActivos();
        }

        [HttpGet("api/v1/ObtenerTodosLosPacientesInactivos")]
        public ActionResult<List<Usuario>> getAllUsuariosPacientesInactivos()
        {
            return _userServi.getAllUsuariosProfesionalesInactivos();
        }
        #endregion

        #region post
        [HttpPost("api/v1/ModificarUsuario")]
        public void ModificarUsuario(Usuario usuario)
        {
            _userServi.modificarUsuario(usuario);
        }

        [HttpPost("api/v1/HabilitarProfesional")]
        public void HabilitarProfesional(int id, bool estado)
        {
            _userServi.HabilitarProfesional(id, estado);
        }

        [HttpPost("api/v1/HabilitaPacientePorProfesional")]
        public void HabilitarPacienteXProfesional(int pacienteId, bool estado)
        {
            _userService.HabilitarPacientes(pacienteId, estado);
        }
        #endregion




    }
}
