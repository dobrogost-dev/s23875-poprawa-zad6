using System.ComponentModel.DataAnnotations;

namespace Kolos_poprawa.Models.DTO
{
    public class GetDTO
    {
        public int ID { get; set; }


/*        
 *        wykorzystywane do podlaczenia kolejnej warstwy jsona
        public ICollection<GetDummyModels> DummyModels { get; set; } = new List<GetDummyModels>();

        public class GetDummyModels
        {
            
        }*/
    }
}
