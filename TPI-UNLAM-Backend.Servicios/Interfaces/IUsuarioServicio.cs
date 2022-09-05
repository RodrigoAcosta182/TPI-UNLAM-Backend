using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;

namespace TPI_UNLAM_Backend.Servicios.Interfaces
{
    public interface IUsuarioServicio
    {
        public void AgregarUsuarioProfesional(Profesionale profesional);
        public void AgregarUsuarioPaciente(Paciente paciente);
        public Paciente getPacienteByEmail(Paciente paciente);
        public void SaveChanges();
    }
}
