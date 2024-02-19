using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Detalleventum
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int ReferenciaVenta { get; set; }

        public virtual Ventum IdVentaNavigation { get; set; } = null!;
    }
}
