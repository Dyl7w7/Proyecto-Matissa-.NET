using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Permiso
    {
        public Permiso()
        {
            Rolxpermisos = new HashSet<Rolxpermiso>();
        }

        public int IdPermiso { get; set; }
        public string Modulo { get; set; } = null!;
        public string? Descripcion { get; set; }

        public virtual ICollection<Rolxpermiso> Rolxpermisos { get; set; }
    }
}
