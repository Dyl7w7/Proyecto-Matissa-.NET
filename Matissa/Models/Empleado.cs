using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Servicios = new HashSet<Servicio>();
        }

        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; } = null!;
        public string ApellidoEmpleado { get; set; } = null!;
        public string Genero { get; set; } = null!;
        public DateOnly FechaContrato { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Correo { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public sbyte Estado { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
