using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IPatientRepository
    {
        List<string> GetReportData(int id);
        int UpdateSelf(Patient patient);
        Patient GetPatient(string email, string password);
        float CalculateBMI(string weight, string height);
        public int DeletePatient(int id);
    }
}
