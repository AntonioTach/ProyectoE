using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class DireccionEntity
    {
        [Key]
        [MaxLength(11)]
        public int DireccionId { get; set; }

        [StringLength(30)]
        public string DireccionCalle { get; set; }

        [StringLength(10)]
        public string DireccionNoExt { get; set; }

        [StringLength(10)]
        public string DireccionNoInt { get; set; }

        [StringLength(10)]
        public string DireccionCp { get; set; }

        [StringLength(30)]
        public string DireccionMunicipio { get; set; }
    }
}
