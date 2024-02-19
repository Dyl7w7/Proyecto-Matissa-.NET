using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Detallecitum
    {
        public int IdDetalleCita { get; set; }
        public int IdCita { get; set; }
        public int IdServicio { get; set; }
        public DateOnly FechaCita { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public int DuracionServicio { get; set; }
        public float Descuento { get; set; }
        public float CostoServicio { get; set; }
        public string Estado { get; set; } = null!;

        public virtual Citum IdCitaNavigation { get; set; } = null!;
        public virtual Servicio IdServicioNavigation { get; set; } = null!;
    }
}
