using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class JefeEntity
    {
        [Key]
        [MaxLength(11)]
        public int JefeId { get; set; }

        [Required]
        [MaxLength(11)]
        public int AcademiaId { get; set; }
        public AcademiaEntity Academia { get; set; }

        [Required]
        [StringLength(11)]
        public string TrabajadorId { get; set; }
        public TrabajadorEntity Trabajador { get; set; }

    }
}
