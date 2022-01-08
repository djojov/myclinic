using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IDoctorRepository
    {
        List<Patient> GetAllPatients();
        int UpdatePatient(Patient patient);
        int InsertPatient(Patient patient);
        Doctor GetDoctor(string email, string password);
        int InsertReport(int doctor_id, int patient_id, string diagnosis);
    }
}
