using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class PuestoEntity
    {
        [Key]
        [MaxLength(11)]
        public int PuestoId { get; set; }

        [Required]
        public DateTime PlazaFechaInicio { get; set; }

        [StringLength(11)]
        public string TrabajadorId { get; set; }
        public TrabajadorEntity Trabajador { get; set; }

        [MaxLength(11)]
        public int AcademiaId { get; set; }
        public AcademiaEntity Academia { get; set; }
    }
}
