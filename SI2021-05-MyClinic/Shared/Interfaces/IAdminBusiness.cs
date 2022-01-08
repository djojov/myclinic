using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IAdminBusiness
    {
        List<Doctor> GetAllDoctors();
        string InsertDoctor(Doctor doc);
        string UpdateDoctor(Doctor doc);
        Admin GetAdmin(string email, string password);
    }
}
