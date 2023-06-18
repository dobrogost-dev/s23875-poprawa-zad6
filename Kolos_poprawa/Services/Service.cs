using Kolos_poprawa.Models;
using Kolos_poprawa.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Kolos_poprawa.Services
{
    public class Service
    {
        public interface IMyService
        {
            //TUTAJ METODA IMPLEMENTOWANA NIZEJ
        }
        public class MyService : IMyService
        {
            private readonly MyContext _db;

            public MyService(MyContext db)
            {
                _db = db;
            }
/*            public async Task<IEnumerable<cosDTO>> getCOSTAM()
            {

            }*/
        }

    }
}
