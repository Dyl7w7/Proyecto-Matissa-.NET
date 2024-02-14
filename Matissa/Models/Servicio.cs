using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matissa.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            DetalleCita = new HashSet<DetalleCitum>();
        }

        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdServicio { get; set; }
        public string NombreServicio { get; set; } = null!;
        public string? Descripción { get; set; }
        public int Duración { get; set; }
        public double Precio { get; set; }
        public byte Estado { get; set; }

        public virtual ICollection<DetalleCitum> DetalleCita { get; set; }
    }
}
