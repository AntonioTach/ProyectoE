using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class PlantelEntity
    {
        [Key]
        [MaxLength(11)]
        public int PlantelId { get; set; }

        [StringLength(30)]
        public string PlantelNombre { get; set; }

        [MaxLength(11)]
        public int DireccionId { get; set; }
        public DireccionEntity Direccion { get; set; }

        public ICollection<TrabajadorEntity> Trabajadores { get; set; }
    }
}
