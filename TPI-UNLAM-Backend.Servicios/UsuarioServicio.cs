﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Servicios
{
    internal class UsuarioServicio : IUsuarioServicio
    {
        private IUsuarioRepositorio _userRepo;

        public UsuarioServicio(IUsuarioRepositorio userRepo)
        {
            _userRepo = userRepo;
        }

        public void AgregarUsuarioProfesional(Profesionale profesional)
        {
            _userRepo.AgregarUsuarioProfesional(profesional);
            _userRepo.SaveChanges();
        }

        public void AgregarUsuarioPaciente(Paciente paciente)
        {
            _userRepo.AgregarUsuarioPaciente(paciente);
            _userRepo.SaveChanges();
        }

        public void SaveChanges()
        {
            _userRepo.SaveChanges();
        }

        public Paciente getPacienteByEmail(string email)
        {
            return _userRepo.getPacienteByEmail(email);
        }

        public Paciente Login(string email, string clave)
        {
            Paciente paciente = new Paciente();
            if (email == null || clave == null)
                throw new Exception("Los datos ingresados incorrectos");

            paciente = _userRepo.getPacienteByEmail(email);

            if (paciente == null)
                throw new Exception("Mail o clave incorrecta");

            if (paciente.Contrasena != clave)
                throw new Exception("Mail o clave incorrecta");

            return paciente;
        }
    }
}
