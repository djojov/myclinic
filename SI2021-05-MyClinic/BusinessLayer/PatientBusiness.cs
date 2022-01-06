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
    }
}
