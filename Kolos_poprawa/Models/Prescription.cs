using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos_poprawa.Models
{
    [Table("Prescription")]
    public class Prescription
    {
        [Key]
        public int IdPrescription { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public int IdDoctor { get; set; }
        public int IdPatient { get; set; }
        [ForeignKey(nameof(IdDoctor))]
        public virtual Doctor Doctor { get; set; } = null!;
        [ForeignKey(nameof(IdPatient))]
        public virtual Patient Patient { get; set; } = null!;
        public virtual ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; } = null!;
    }
}
