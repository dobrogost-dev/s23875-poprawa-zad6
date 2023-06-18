using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolos_poprawa.Models.DTO
{
    [Table("DummyModel")]
    public class DummyModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

/*
        stosujemy to w klasie w ktorej na rysunku jest jedna      
        public virtual ICollection<Klasa_X> Klasa_X-w liczbie mnogiej { get; set; } = null!;

        stosujemy to w klasie w której na rysunku jest kilka linijek
        public DummyModel DummyModel - liczba pojedyncza { get; set; } = null!;
*/
    }
}
