using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Detallepedidos = new HashSet<Detallepedido>();
        }

        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateOnly FechaPedido { get; set; }
        public float PrecioTotalPedido { get; set; }
        public sbyte Estado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<Detallepedido> Detallepedidos { get; set; }
    }
}
