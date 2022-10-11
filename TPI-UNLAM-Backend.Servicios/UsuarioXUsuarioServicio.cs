﻿using Microsoft.IdentityModel.SecurityTokenService;
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
    public class UsuarioXUsuarioServicio : IUsuarioXUsuarioServicio
    {
        private IUsuarioXUsuarioRepositorio _userXuser;
        private IAppSharedFunction _appSharedFunction;
        private IUsuarioRepositorio _userRepo;
        public UsuarioXUsuarioServicio(IUsuarioXUsuarioRepositorio userXuser, IAppSharedFunction appSharedFunction, IUsuarioRepositorio userRepo)
        {
            _userXuser = userXuser;
            _appSharedFunction = appSharedFunction;
            _userRepo = userRepo;
        }


        public void HabilitarPacientes(int pacienteId, bool estado)
        {
            Usuario user =_userRepo.getUsuarioById(pacienteId);

            string email = _appSharedFunction.GetUsuarioPorToken();
            Usuario usuario = _userRepo.getUsuarioByEmail(email);

            UsuarioXusuario habilitarPaciente = _userXuser.HabilitarPacienteXProfesional(usuario.Id, pacienteId);

            if (habilitarPaciente == null)
                throw new BadRequestException("No se encuentro dicho paciente");

            if (estado == false)
            {
                habilitarPaciente.Activo = true;
                habilitarPaciente.FechaInicioRelacion = DateTime.Now;
            }
            else
            {
                habilitarPaciente.Activo = false;
                habilitarPaciente.FechaFinalizacionRelacion = DateTime.Now;
            }

            _userXuser.SaveChanges();

        }

        public List<UsuarioXusuario> getPacienteXProfesional()
        {
            string email = _appSharedFunction.GetUsuarioPorToken();
            Usuario usuario = _userRepo.getUsuarioByEmail(email);
            return _userXuser.getPacienteXProfesional(usuario.Id).ToList();
        }

        public List<UsuarioXusuario> getPacienteXProfesionalActivos()
        {
            string email = _appSharedFunction.GetUsuarioPorToken();
            Usuario usuario = _userRepo.getUsuarioByEmail(email);
            return _userXuser.getPacienteXProfesionalActivos(usuario.Id).ToList();
        }

        public List<UsuarioXusuario> getPacienteXProfesionalInactivos()
        {
            string email = _appSharedFunction.GetUsuarioPorToken();
            Usuario usuario = _userRepo.getUsuarioByEmail(email);
            return _userXuser.getPacienteXProfesionalInactivos(usuario.Id).ToList();
        }

        public UsuarioXusuario getProfesionalXPaciente(int UsuarioLogeadoId)
        {
            string email = _appSharedFunction.GetUsuarioPorToken();
            Usuario usuario = _userRepo.getUsuarioByEmail(email);
            return _userXuser.getProfesionalXPaciente(usuario.Id);
        }
    }
}
