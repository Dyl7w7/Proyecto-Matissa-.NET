using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Rolxpermisos = new HashSet<Rolxpermiso>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string NombreRol { get; set; } = null!;
        public sbyte? Estado { get; set; }

        public virtual ICollection<Rolxpermiso> Rolxpermisos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
