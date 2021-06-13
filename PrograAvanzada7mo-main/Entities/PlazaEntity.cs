using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class PlazaEntity
    {
        [Key]
        [MaxLength(11)]
        public int PlazaId { get; set; }

        [Required]
        [StringLength(100)]
        public string PlazaTipo { get; set; }

        public ICollection<TrabajadorEntity> Trabajadores { get; set; }
    }
}