using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RualesMProgreso1.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "La raza no puede exceder los 50 caracteres.")]
        public string Raza { get; set; }
        [Required]
        public string sexo { get; set; }
        [Required]
        public DateOnly fechaNacimiento { get; set; }

        [ForeignKey("DuenoId")]
        public int? DuenoId { get; set; }
        public Dueno? Dueno { get; set; }



    }
}
