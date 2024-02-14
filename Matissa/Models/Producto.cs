using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Detallecompras = new HashSet<Detallecompra>();
            Detallepedidos = new HashSet<Detallepedido>();
        }

        public int IdProducto { get; set; }
        public string NombreProducto { get; set; } = null!;
        public string? Descripcion { get; set; }
        public DateOnly FechaCaducidad { get; set; }
        public float PrecioVenta { get; set; }
        public int SaldoInventario { get; set; }
        public sbyte Estado { get; set; }

        public virtual ICollection<Detallecompra> Detallecompras { get; set; }
        public virtual ICollection<Detallepedido> Detallepedidos { get; set; }
    }
}
