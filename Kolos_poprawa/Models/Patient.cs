using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kolos_poprawa.Models
{
    [Table("Patient")]
    public class Patient
    {
        [Key]
        public int IdPatient { get; set; }
        [MaxLength(100), Required]
        public string FirstName { get; set; } = null!;
        [MaxLength(100), Required]
        public string LastName { get; set; } = null!;
        [Required]
        public DateTime Birthdate { get; set; }
    }
}
