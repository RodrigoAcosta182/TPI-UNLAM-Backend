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
    public class ProgresosXUsuarioXJuegoServicio : IProgresosXUsuarioXJuegoServicio
    {

        private IAppSharedFunction _appSharedFunction;
        private IProgresosXUsuarioXJuegoRepositorio _progresoRepo;
        private IUsuarioRepositorio _userRepo;


        public ProgresosXUsuarioXJuegoServicio(IAppSharedFunction appSharedFunction, IProgresosXUsuarioXJuegoRepositorio progreso, IUsuarioRepositorio userRepo)
        {
            _appSharedFunction = appSharedFunction;
            _progresoRepo = progreso;
            _userRepo = userRepo;
        }

        public List<ProgresosXusuarioXjuego> getAllProgresoXPaciente()
        {
            string mailPacienteLogueado = _appSharedFunction.GetUsuarioPorToken();

            Usuario paciente = _userRepo.getUsuarioByEmail(mailPacienteLogueado);

            return _progresoRepo.getAllProgresoXPaciente(paciente);
        }

        public ProgresosXusuarioXjuego getAllProgresoXPacienteXJuego(int juegoId)
        {
            string mailPacienteLogueado = _appSharedFunction.GetUsuarioPorToken();

            Usuario paciente = _userRepo.getUsuarioByEmail(mailPacienteLogueado);

            return _progresoRepo.getAllProgresoXPacienteXJuego(paciente, juegoId);
        }

        public List<ProgresosXusuarioXjuego> getAllProgresoXProfesional()
        {
            string mailProfesionalLogueado = _appSharedFunction.GetUsuarioPorToken();

            Usuario profesional = _userRepo.getUsuarioByEmail(mailProfesionalLogueado);
            return _progresoRepo.getAllProgresoXProfesional(profesional);
        }

        public ProgresosXusuarioXjuego getProgresoXPacienteXJuegoXProfesional(Usuario paciente, int juegoid)
        {
            string mailProfesionalLogueado = _appSharedFunction.GetUsuarioPorToken();

            Usuario profesional = _userRepo.getUsuarioByEmail(mailProfesionalLogueado);
            return _progresoRepo.getProgresoXPacienteXJuegoXProfesional(paciente, juegoid, profesional);
        }

        public List<ProgresosXusuarioXjuego> getProgresoXProfesionalXPaciente(Usuario paciente)
        {
            string mailProfesionalLogueado = _appSharedFunction.GetUsuarioPorToken();

            Usuario profesional = _userRepo.getUsuarioByEmail(mailProfesionalLogueado);
            return _progresoRepo.getProgresoXProfesionalXPaciente(paciente, profesional);
        }

        public void SaveChanges()
        {
            _progresoRepo.SaveChanges();
        }
    }
}
