using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    interface IPatientRepository
    {
        List<string> GetReportData(int id);
        int UpdateSelf(Patient patient);
    }
}
