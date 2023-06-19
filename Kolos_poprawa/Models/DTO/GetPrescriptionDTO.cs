namespace Kolos_poprawa.Models.DTO
{
    public class GetPrescriptionDTO
    {
        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public GetDoctorDTO? Doctor { get; set; }
        public GetPatientDTO? Patient { get; set; }
        public ICollection<GetMedicamentDTO> Medicaments { get; set; } = new List<GetMedicamentDTO>();
    }
    public class GetPatientDTO
    {
        public int IdPatient { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
    }
    public class GetMedicamentDTO
    {
        public int IdMedicament { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Type { get; set; } = null!;
    }
}
