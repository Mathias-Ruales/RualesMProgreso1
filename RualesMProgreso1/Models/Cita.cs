using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RualesMProgreso1.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public bool requireMedicacion { get; set; }
        public decimal tarifa { get; set; }

        public int? MascotaId { get; set; }
        [ForeignKey("MascotaId")]
        public Mascota? Mascota { get; set; }
    }
}
