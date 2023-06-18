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
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected MyContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medicament>(e =>
            {
                e.HasData(new List<Medicament>
                {
                    new Medicament
                    {
                        IdMedicament = 1,
                        Description = "desc",
                        Name = "name",
                        Type = "type"
                    }
            }); ;
            });
            modelBuilder.Entity<Prescription_Medicament>(e =>
            {
                e.HasData(new List<Prescription_Medicament>
                {
                    new Prescription_Medicament
                    {
                        IdMedicament = 1,
                        IdPrescription = 1,
                        Dose = 3,
                        Details = "details"
                    }
            }); ;
            });
            modelBuilder.Entity<Prescription>(e =>
            {
                e.HasData(new List<Prescription>
                {
                    new Prescription
                    {
                        IdPrescription = 1,
                        IdDoctor = 1,
                        IdPatient = 1,
                        Date = DateTime.Now,
                        DueDate = DateTime.Now,
                    }
            }); ;
            });
            modelBuilder.Entity<Doctor>(e =>
            {
                e.HasData(new List<Doctor>
                {
                    new Doctor
                    {
                        IdDoctor = 1,
                        FirstName = "Adrian",
                        LastName = "Dylag",
                        Email = "adylag@gmail.com"
                    }
            }); ;
            });
            modelBuilder.Entity<Patient>(e =>
            {
                e.HasData(new List<Patient>
                {
                    new Patient
                    {
                        IdPatient = 1,
                        FirstName = "Janusz",
                        LastName = "Tracz",
                        Birthdate = DateTime.Now,
                    }
            }); ;
            });
        }
    }
}
