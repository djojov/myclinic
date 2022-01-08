using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IPatientBusiness
    {
        List<string> GetReportData(int id);
        string UpdateSelf(Patient patient);
        string CalculateBMI(string weight, string height);
    }
}
