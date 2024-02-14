using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Cita = new HashSet<Citum>();
            Pedidos = new HashSet<Pedido>();
            Venta = new HashSet<Ventum>();
        }

        public int IdCliente { get; set; }
        public string NombreCliente { get; set; } = null!;
        public string ApellidoCliente { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public DateOnly Nacimiento { get; set; }
        public string Direccion { get; set; } = null!;
        public sbyte Estado { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
