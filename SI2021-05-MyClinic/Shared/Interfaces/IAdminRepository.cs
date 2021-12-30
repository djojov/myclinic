using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    interface IAdminRepository
    {
        List<Doctor> GetAllDoctors();
        int UpdateDoctor(Doctor doc);
        int InsertDoctor(Doctor doc);
    }
}
