using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RualesMProgreso1.Models
{
    public class Dueno
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; }
        [Required]
        [Phone]
        public string Telefono { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(100, ErrorMessage = "El correo no puede exceder los 100 caracteres.")]
        public string Correo { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaVisita { get; set; }
        public bool tieneMascota { get; set; }

    }       
}
