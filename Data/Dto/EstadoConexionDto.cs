namespace TIP_UNLAM_Backend.Data.Dto
{
    public class EstadoConexionDto
    {
        public bool online { get; set; }
        public string emailProfesional { get; set; }
        public UsuarioDto paciente { get; set; }


    }
}
