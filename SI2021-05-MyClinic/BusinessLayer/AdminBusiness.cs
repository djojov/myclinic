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
                return "Doctor successfully added!";
            }
            else
            {
                return "Doctor insertion failed!";
            }
        }
        public string UpdateDoctor(Doctor doctor)
        {
            int rowsAffected = this.adminRepository.UpdateDoctor(doctor);

            if (rowsAffected > 0)
            {
                return "Doctor successfully updated!";
            }
            else
            {
                return "Failed to update doctor!";
            }
        }

        public Admin GetAdmin(string email, string password)
        {
            return this.adminRepository.GetAdmin(email,password);
        }
    }
}
