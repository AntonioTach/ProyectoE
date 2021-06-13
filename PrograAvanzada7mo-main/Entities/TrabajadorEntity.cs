using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class TrabajadorEntity
    {
        [Key]
        [StringLength(11)]
        public string TrabajadorNomina { get; set; }

        [Required]
        [StringLength(100)]
        public string TrabajadorRegistro { get; set; }

        [Required]
        [StringLength(30)]
        public string TrabajadorNombre { get; set; }

        [Required]
        [StringLength(30)]
        public string TrabajadorApPaterno { get; set; }

        [Required]
        [StringLength(30)]
        public string TrabajadorApMaterno { get; set; }

        [Required]
        [StringLength(30)]
        public string TrabajadorCurp { get; set; }

        [Required]
        [StringLength(30)]
        public string TrabajadorTelefono { get; set; }

        [Required]
        [StringLength(30)]
        public string TrabajadorCelular { get; set; }

        [Required]
        [StringLength(30)]
        public string TrabajadorEmail { get; set; }

        [Required]
        public DateTime TrabajadorFechaNacimiento { get; set; }

        [MaxLength(11)]
        public int PlantelId { get; set; }
        public PlantelEntity Plantel { get; set; }

        [Required]
        [MaxLength(11)]
        public int DireccionId { get; set; }
        public DireccionEntity Direccion { get; set; }

        [Required]
        [MaxLength(11)]
        public int PlazaId { get; set; }
        public PlazaEntity Plaza { get; set; }
    }
}
