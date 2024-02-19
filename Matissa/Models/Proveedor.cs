using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Compras = new HashSet<Compra>();
        }

        public int IdProveedor { get; set; }
        public string TipoProveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public sbyte Estado { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}
