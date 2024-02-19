using System;
using System.Collections.Generic;

namespace Matissa.Models
{
    public partial class Rolxpermiso
    {
        public int IdRolXpermiso { get; set; }
        public int IdRol { get; set; }
        public int IdPermiso { get; set; }

        public virtual Permiso IdPermisoNavigation { get; set; } = null!;
        public virtual Rol IdRolNavigation { get; set; } = null!;
    }
}
