using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Ventum
    {
        public Ventum()
        {
            Detalleventa = new HashSet<Detalleventum>();
        }

        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public DateOnly FechaVenta { get; set; }
        public float PrecioVenta { get; set; }
        public string FormaPago { get; set; } = null!;
        public sbyte Estado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<Detalleventum> Detalleventa { get; set; }
    }
}
