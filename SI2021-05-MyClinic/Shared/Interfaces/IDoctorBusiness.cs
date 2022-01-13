using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IDoctorBusiness
    {
        List<Patient> GetAllPatients();
        string UpdatePatient(Patient patient);
        string InsertPatient(Patient patient);
        string InsertReport(int doctor_id, int patient_id, string diagnosis);
        Doctor GetDoctor(string email, string password);
        string DeleteDoctor(int id);
    }
}