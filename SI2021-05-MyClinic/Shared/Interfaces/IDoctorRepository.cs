using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    interface IDoctorRepository
    {
        List<Patient> GetAllPatients();
        int UpdatePatient(Patient patient);
        int InsertPatient(Patient patient);
    }
}
