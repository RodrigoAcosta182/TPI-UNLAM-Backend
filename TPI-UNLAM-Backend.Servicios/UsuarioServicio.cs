using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.Dto;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Servicios
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private IUsuarioRepositorio _userRepo;

        public UsuarioServicio(IUsuarioRepositorio userRepo)
        {
            _userRepo = userRepo;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            if (getUsuarioByEmail(usuario.Mail) != null)
                throw new Exception("Ya existe el usuario");

            if (ContrasenaSegura(usuario.Contrasena) == false)
                throw new Exception("Verificar que la clave tenga un minimo de 8 caracteres, al menos tenga un caracter, un numero y un caracter especial");

            if (ValidateEmail(usuario.Mail))
                throw new Exception("El mail no es valido");

            usuario.FechaAlta = DateTime.Now;
            usuario.Activo = true;
            
            if (String.IsNullOrEmpty(usuario.Matricula))
            {
                usuario.TipoUsuarioId = 1;
            }
            else
            {
                usuario.TipoUsuarioId = 2;
            }

            _userRepo.AgregarUsuario(usuario);
            _userRepo.SaveChanges();
        }

        public void SaveChanges()
        {
            _userRepo.SaveChanges();
        }

        public Usuario getUsuarioByEmail(string email)
        {
            return _userRepo.getUsuarioByEmail(email);
        }

        public Usuario Login(LoginDto loginDto)
        {
            Usuario usuario = new Usuario();
            if (loginDto.email == null || loginDto.contrasena == null)
                throw new Exception("Los datos ingresados incorrectos");

            usuario = _userRepo.getUsuarioByEmail(loginDto.email);

            if (usuario == null)
                throw new Exception("Mail o clave incorrecta");

            if (usuario.Contrasena != loginDto.contrasena)
                throw new Exception("Mail o clave incorrecta");

            return usuario;
        }

        private Boolean ValidateEmail(String email)
        {
            if (email == null)
                return false;
            
            if (new EmailAddressAttribute().IsValid(email))
                return true;

            return false;
        }

        private Boolean ContrasenaSegura(String contraseñaSinVerificar)
        {
            //letras de la A a la Z, mayusculas y minusculas
            Regex letras = new Regex(@"[a-zA-z]");
            //digitos del 0 al 9
            Regex numeros = new Regex(@"[0-9]");
            //cualquier caracter del conjunto
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");

            Boolean cumpleCriterios = false;

            //si no contiene las letras, regresa false
            if (!letras.IsMatch(contraseñaSinVerificar))
                return false;

            //si no contiene los numeros, regresa false
            if (!numeros.IsMatch(contraseñaSinVerificar))
                return false;
            
            //si no contiene los caracteres especiales, regresa false
            if (!caracEsp.IsMatch(contraseñaSinVerificar))
                return false;

            //Si la contraseña tiene menos de 8 caracteres, regresa false
            if (contraseñaSinVerificar.Length < 8)
                return false;

            //si cumple con todo, regresa true
            return true;
}
    }
}
