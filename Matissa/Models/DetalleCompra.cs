using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Detallecompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public float PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public float CostoTotalUnitario { get; set; }

        public virtual Compra IdCompraNavigation { get; set; } = null!;
        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
