using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class PermisoEntity
    {
        [Key]
        [MaxLength(11)]
        public int PermisoId { get; set; }

        [Required]
        [StringLength(30)]
        public string PermisoTipo { get; set; }

        [Required]
        public DateTime PermisoFechaElaboracion { get; set; }

        [Required]
        public DateTime PermisoFechaAplicacion { get; set; }

        [Required]
        public DateTime PermisoFechaFinalizacion { get; set; }

        [Required]
        public string PermisoMotivo { get; set; }

        [Required]
        [StringLength(30)]
        public string PermisoEstado { get; set; }

        [Required]
        [StringLength(11)]
        public string TrabajadorId { get; set; }
        public TrabajadorEntity Trabajador { get; set; }

        [MaxLength(11)]
        public int? JefeInmediatoId { get; set; }
        public JefeEntity JefeInmediato { get; set; }

    }
}
