using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AdminBusiness : IAdminBusiness
    {
        private readonly IAdminRepository adminRepository;

        public AdminBusiness(IAdminRepository _adminRepository)
        {
            adminRepository = _adminRepository;
        }

        public List<Doctor> GetAllDoctors()
        {
            return this.adminRepository.GetAllDoctors();
        }
        public string InsertDoctor(Doctor doctor)
        {
            int rowsAffected = this.adminRepository.InsertDoctor(doctor);

            if (rowsAffected > 0)
            {
                return "Uspešno ste uneli doktora u bazu!";
            }
            else
            {
                return "Neuspešan unos doktora, došlo je do greške!";
            }
        }
        public string UpdateDoctor(Doctor doctor)
        {
            int rowsAffected = this.adminRepository.UpdateDoctor(doctor);

            if (rowsAffected > 0)
            {
                return "Podaci doktora su uspešno ažurirani!";
            }
            else
            {
                return "Neuspešno ažuriranje doktora, došlo je do greške!";
            }
        }
    }
}
