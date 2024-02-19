using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Compra
    {
        public Compra()
        {
            Detallecompras = new HashSet<Detallecompra>();
        }

        public int IdCompra { get; set; }
        public int IdProveedor { get; set; }
        public string? Descripcion { get; set; }
        public DateOnly FechaCompra { get; set; }
        public float CostoTotalCompra { get; set; }
        public string? Factura { get; set; }
        public sbyte Estado { get; set; }

        public virtual Proveedor IdProveedorNavigation { get; set; } = null!;
        public virtual ICollection<Detallecompra> Detallecompras { get; set; }
    }
}
