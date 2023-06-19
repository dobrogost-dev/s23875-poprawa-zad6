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
            public Task AddDoctor(GetDoctorWithoudIdDTO doctor);
            public Task<bool> DeleteDoctor(int doctorId);
            public Task<GetDoctorDTO> GetDoctorById(int DoctorId);
            public Task<ICollection<GetDoctorDTO>> GetDoctors();
            public Task<GetPrescriptionDTO> GetPrescriptionById(int PrescriptionId);
            public Task<bool> UpdateDoctor(GetDoctorDTO doctor);
        }
        public class MyService : IMyService
        {
            private readonly MyContext _db;

            public MyService(MyContext db)
            {
                _db = db;
            }

            public async Task AddDoctor(GetDoctorWithoudIdDTO doctor)
            {
                var newDoctor = new Doctor
                {
                    FirstName = doctor.FirstName,
                    LastName = doctor.LastName,
                    Email = doctor.Email
                };
                await _db.AddAsync(newDoctor);
                await _db.SaveChangesAsync();
            }

            public async Task<bool> DeleteDoctor(int doctorId)
            {
                if (_db.Doctors.Any(d => d.IdDoctor == doctorId))
                {
                    var doctor = _db.Doctors.FirstOrDefault(d => d.IdDoctor == doctorId);
                    _db.Remove<Doctor>(doctor);
                    await _db.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public async Task<GetDoctorDTO> GetDoctorById(int DoctorId)
            {
                var doctor = await _db.Doctors.FirstOrDefaultAsync(doctor => doctor.IdDoctor == DoctorId);
                if (doctor is not null)
                {
                    return new GetDoctorDTO
                    {
                        IdDoctor = doctor.IdDoctor,
                        FirstName = doctor.FirstName,
                        LastName = doctor.LastName,
                        Email = doctor.Email
                    };
                } else
                {
                    return null;
                }
            }

            public async Task<ICollection<GetDoctorDTO>> GetDoctors()
            {
                return await _db.Doctors.Select(doctor => new GetDoctorDTO
                {
                    IdDoctor = doctor.IdDoctor,
                    FirstName = doctor.FirstName,
                    LastName = doctor.LastName,
                    Email = doctor.Email
                }).ToListAsync();
            }

            public async Task<GetPrescriptionDTO> GetPrescriptionById(int PrescriptionId)
            {
                var prescription = await _db.Prescriptions.Include(d => d.Doctor)
                    .Include(p => p.Patient)
                    .Include(pm => pm.Prescription_Medicaments)
                    .ThenInclude(m => m.Medicament)
                    .ToListAsync();

                return prescription.Where(p => p.IdPrescription == PrescriptionId).Select(e => new GetPrescriptionDTO
                {
                    IdPrescription = e.IdPrescription,
                    Date = e.Date,
                    DueDate = e.DueDate,
                    Doctor = new GetDoctorDTO
                    {
                        IdDoctor = e.Doctor.IdDoctor,
                        FirstName = e.Doctor.FirstName,
                        LastName = e.Doctor.LastName,
                        Email = e.Doctor.Email
                    },
                    Patient = new GetPatientDTO
                    {
                        IdPatient = e.Patient.IdPatient,
                        FirstName = e.Patient.FirstName,
                        LastName = e.Patient.LastName,
                        BirthDate = e.Patient.Birthdate
                    },
                    Medicaments = e.Prescription_Medicaments.Select(m => new GetMedicamentDTO
                    {
                        IdMedicament = m.Medicament.IdMedicament,
                        Name = m.Medicament.Name,
                        Description = m.Medicament.Description,
                        Type = m.Medicament.Type,
                    }).ToList()
                }).FirstOrDefault(); 
            }

            public async Task<bool> UpdateDoctor(GetDoctorDTO doctor)
            {
                if (_db.Doctors.Any(d => d.IdDoctor == doctor.IdDoctor))
                {
                    var newDoctor = _db.Doctors.FirstOrDefault(d => d.IdDoctor == doctor.IdDoctor);
                    newDoctor.LastName = doctor.LastName;
                    newDoctor.FirstName = doctor.FirstName;
                    newDoctor.Email = doctor.Email;
                    await _db.SaveChangesAsync();
                    return true;
                }
                return false;
            }
        }

    }
}
