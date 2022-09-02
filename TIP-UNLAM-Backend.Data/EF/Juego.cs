﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TIP_UNLAM_Backend.Data.EF
{
    public partial class Juego
    {
        public Juego()
        {
            ProgresosXpacientesXjuegos = new HashSet<ProgresosXpacientesXjuego>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Ruta { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<ProgresosXpacientesXjuego> ProgresosXpacientesXjuegos { get; set; }
    }
}
