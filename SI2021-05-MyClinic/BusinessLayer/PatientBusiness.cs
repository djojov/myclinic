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
                return "Successfully updated!";
            }
            else
            {
                return "Update failed!";
            }
        }
        public string CalculateBMI(string weight, string height)
        {
            float bmi = this.patientRepository.CalculateBMI(weight,height);

            if (bmi > 0 && bmi < 18.5)
            {
                return "Underweight!";
            }
            else if(bmi > 18.5 && bmi < 25)
            {
                return "Healthy!";
            }
            else if (bmi > 25 && bmi < 30)
            {
                return "Overweight!";
            }
            else if (bmi > 30)
            {
                return "Obese!";
            }
            else
            {
                return "Incorrect data!";
            }
        }
        public Patient GetPatient(string email, string password)
        {
            return this.patientRepository.GetPatient(email, password);
        }
    }
}
