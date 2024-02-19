using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Citum
    {
        public Citum()
        {
            Detallecita = new HashSet<Detallecitum>();
        }

        public int IdCita { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public float CostoTotal { get; set; }
        public sbyte Estado { get; set; }
        public int IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<Detallecitum> Detallecita { get; set; }
    }
}
