using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class AcademiaEntity
    {
        [Key]
        [MaxLength(11)]
        public int AcademiaId { get; set; }

        [StringLength(50)]
        public string AcademiaNombre { get; set; }

        public ICollection<JefeEntity> Jefes { get; set; }
    }
}
