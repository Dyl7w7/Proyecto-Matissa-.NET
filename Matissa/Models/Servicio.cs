using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            Detallecita = new HashSet<Detallecitum>();
        }

        public int IdServicio { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreServicio { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int Duracion { get; set; }
        public float Precio { get; set; }
        public sbyte Estado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;
        public virtual ICollection<Detallecitum> Detallecita { get; set; }
    }
}
