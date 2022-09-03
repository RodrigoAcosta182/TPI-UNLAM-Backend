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
        }

        public void AgregarUsuarioPaciente(Paciente paciente)
        {
            _userRepo.AgregarUsuarioPaciente(paciente);
        }

        public void SaveChanges()
        {
            _userRepo.SaveChanges();    
        }
    }
}
