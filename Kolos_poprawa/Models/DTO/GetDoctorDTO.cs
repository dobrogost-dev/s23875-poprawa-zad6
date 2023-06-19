using System.ComponentModel.DataAnnotations;

namespace Kolos_poprawa.Models.DTO
{
    public class GetDoctorDTO
    {
        [Key, Required]
        public int IdDoctor { get; set; }
        [MaxLength(100), Required]
        public string FirstName { get; set; } = null!;
        [MaxLength(100), Required]
        public string LastName { get; set; } = null!;
        [MaxLength(100), Required]
        public string Email { get; set; } = null!;
    }
    public class GetDoctorWithoudIdDTO
    {
        [MaxLength(100), Required]
        public string FirstName { get; set; } = null!;
        [MaxLength(100), Required]
        public string LastName { get; set; } = null!;
        [MaxLength(100), Required]
        public string Email { get; set; } = null!;
    }
}
