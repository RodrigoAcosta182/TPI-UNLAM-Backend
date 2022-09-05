using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;

namespace TIP_UNLAM_Backend.Data.Repositorios
{
    internal class UsuarioRepositorio : IUsuarioRepositorio
    {
        private TPI_UNLAM_DBContext _ctx;

        public UsuarioRepositorio(TPI_UNLAM_DBContext ctx)
        {
            _ctx = ctx;
        }

        public void AgregarUsuarioProfesional(Profesionale profesional)
        {
            _ctx.Add(profesional);
        }

        public void AgregarUsuarioPaciente(Paciente paciente)
        {
            _ctx.Add(paciente);
        }

        public Paciente getPacienteByEmail(string email)
        {
            return _ctx.Pacientes.Find(email);
        }


        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }

        public Paciente getPacienteByEmail(Paciente paciente)
        {
            return _ctx.Pacientes.Find(paciente.Mail);
        }
    }
}
