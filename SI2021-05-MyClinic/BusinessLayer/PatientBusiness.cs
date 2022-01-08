using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PatientBusiness : IPatientBusiness
    {
        private readonly IPatientRepository patientRepository;

        public PatientBusiness(IPatientRepository _patientRepository)
        {
            patientRepository = _patientRepository;
        }

        public List<string> GetReportData(int id)
        {
            return this.patientRepository.GetReportData(id);
        }

        public string UpdateSelf(Patient patient)
        {
            int rowsAffected = this.patientRepository.UpdateSelf(patient);

            if (rowsAffected > 0)
            {
                return "Podaci su uspešno ažurirani!";
            }
            else
            {
                return "Neuspešno ažuriranje, došlo je do greške!";
            }
        }
        public string CalculateBMI(string weight, string height)
        {
            float bmi = this.patientRepository.CalculateBMI(weight,height);

            if (bmi > 0 && bmi < 18.5)
            {
                return "Vas stepen uhranjenosti je slab!";
            }
            else if(bmi > 18.5 && bmi < 25)
            {
                return "Vas stepen uhranjenosti je normalan!";
            }
            else if (bmi > 25 && bmi < 30)
            {
                return "Vas stepen uhranjenosti je prekomeren!";
            }
            else if (bmi > 30)
            {
                return "Vas stepen uhranjenosti je gojazan!";
            }
            else
            {
                return "Nepravilno uneti podaci!";
            }
        }
        public Patient GetPatient(string email, string password)
        {
            return this.patientRepository.GetPatient(email, password);
        }
    }
}
