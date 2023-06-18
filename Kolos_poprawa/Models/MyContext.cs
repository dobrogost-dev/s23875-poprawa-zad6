using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Security.Cryptography.Xml;

namespace Kolos_poprawa.Models

{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }
        //TUTAJ WSTAWIC WSZYSTKIE MODELE JAKO
        // public DbSet<Client> Clients { get; set; }
        protected MyContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NAZWA_MODELU>(e =>
            {
                e.HasData(new List<NAZWA_MODELU>
                {
                    new NAZWA_MODELU
                    {

                    },
                    new NAZWA_MODELU
                    {

                    }
            }); ;
            });
        }
    }
}
