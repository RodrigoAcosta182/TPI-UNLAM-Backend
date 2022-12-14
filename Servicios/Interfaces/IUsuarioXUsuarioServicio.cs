using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grandin.Web.EF;
using TIP_UNLAM_Backend.Data.Procedure;

namespace TPI_UNLAM_Backend.Servicios.Interfaces
{
    public interface IUsuarioXUsuarioServicio
    {
        public List<UsuarioXusuario> getPacienteXProfesional();
        public Usuario getProfesionalXPaciente();
        public void HabilitarPacientes(int pacienteId, bool estado);
        public List<vMisPacientes> MisPacientes();
    }
}
