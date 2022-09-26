﻿using Microsoft.IdentityModel.SecurityTokenService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIP_UNLAM_Backend.Data.EF;
using TIP_UNLAM_Backend.Data.Repositorios.Interfaces;
using TPI_UNLAM_Backend.Servicios.Interfaces;

namespace TPI_UNLAM_Backend.Servicios
{
    public class JuegoServicio : IJuegoServicio
    {
        private IJuegoRepositorio _juegoRepo;
        private IUsuarioRepositorio _userRepo;

        public JuegoServicio(IJuegoRepositorio juegoRepo, IUsuarioRepositorio userRepo)
        {
            _juegoRepo = juegoRepo;
            _userRepo = userRepo;
        }

        public void FinalizarJuego(ProgresosXusuarioXjuego juego)
        {
            if (juego == null)
                throw new BadRequestException("No se enviaron los campos");

            if (_juegoRepo.getJuegoById(juego.JuegoId) == null)
                throw new BadRequestException("No existe juego");

            if (_userRepo.getUsuarioById(juego.UsuarioId) == null)
                throw new BadRequestException("No existe usuario");
            juego.FechaFinalizacion = DateTime.Now;

            _juegoRepo.FinalizarJuego(juego);
            _juegoRepo.SaveChanges();
        }

        public List<Colore> getAllColores()
        {
            return _juegoRepo.getAllColores();
        }

        public List<Juego> getAllJuegos()
        {
            return _juegoRepo.getAllJuegos();
        }

        public Juego getJuegoById(int idJuego)
        {
            return _juegoRepo.getJuegoById(idJuego);
        }

        public void SaveChanges()
        {
            _juegoRepo.SaveChanges();
        }

        public bool validarStringIguales(string campo1, string campo2)
        {
            try
            {
                if (campo1 == null || campo2 == null)
                    throw new BadRequestException("No se enviaron los campos");

                if (campo1 == campo2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public List<int> getNumerosDesordenados()
        {
            List<int> numerosDesordenados = new List<int>();
            Random r = new Random();


            do
            {
                for (int i = 0; i <= 3; i++)
                {
                    int valor = r.Next(1, 5);

                    if (!numerosDesordenados.Contains(valor))
                    {
                        numerosDesordenados.Add(valor);
                    }
                }
            } while (numerosDesordenados.Count < 4);

            return numerosDesordenados;
        }

        public Boolean verificarNumerosOrdenados(List<int> numeros)
        {
            bool estado = false;
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > numeros[i + 1])
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
            }
            return estado;
        }

        public string getImagenPorJuego(string codigo)
        {
            const string carpeta = @"\Content\imagenes\";
            try
            {
                if (codigo == null)
                    throw new BadRequestException("El campo codigo es nulo");

                Juego game = _juegoRepo.getImagenPorJuego(codigo);

                if (game == null)
                    throw new BadRequestException("No existe codigo");

                if (game.Imagen == null)
                    throw new BadRequestException("No existe ruta para el juego");

                if (!Directory.Exists(Path.GetDirectoryName(carpeta)))
                   Directory.CreateDirectory(Path.GetDirectoryName(carpeta));

                return game.Imagen;
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }
    }
}
