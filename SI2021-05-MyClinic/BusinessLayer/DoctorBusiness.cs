using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DoctorBusiness : IDoctorBusiness
    {
        private readonly IDoctorRepository doctorRepository;

        public DoctorBusiness(IDoctorRepository _doctorRepository)
        {
            doctorRepository = _doctorRepository;
        }

        public List<Patient> GetAllPatients()
        {
            return this.doctorRepository.GetAllPatients();
        }
        public string InsertPatient(Patient patient)
        {
            int rowsAffected = this.doctorRepository.InsertPatient(patient);

            if (rowsAffected > 0)
            {
                return "Uspešno ste uneli pacijenta u bazu!";
            }
            else
            {
                return "Neuspešan unos pacijenta, došlo je do greške!";
            }
        }
        public string UpdatePatient(Patient patient)
        {
            int rowsAffected = this.doctorRepository.UpdatePatient(patient);

            if (rowsAffected > 0)
            {
                return "Podaci pacijenta su uspešno ažurirani!";
            }
            else
            {
                return "Neuspešno ažuriranje pacijenta, došlo je do greške!";
            }
        }
        public string InsertReport(int doctor_id, int patient_id, string diagnosis)
        {
            int rowsAffected = this.doctorRepository.InsertReport(doctor_id, patient_id, diagnosis);

            if (rowsAffected > 0)
            {
                return "Uspešno ste dodali novi pregled u bazu!";
            }
            else
            {
                return "Neuspešno dodavanje pregleda u bazu!";
            }
        }
    }
}
