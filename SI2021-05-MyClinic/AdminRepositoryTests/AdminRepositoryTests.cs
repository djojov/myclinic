using DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Interfaces;
using Shared.Models;
using System;

namespace AdminRepositoryTests
{
    [TestClass]
    public class AdminRepositoryTests
    {
        public Admin admin;
        public IAdminRepository adminRepository;

        public Doctor doctor;
        public IDoctorRepository doctorRepository;
        [TestInitialize]
        public void init()
        {
            admin = new Admin
            {
                Id = 2,
                FirstName = "Boban",
                LastName = "Bobanovic",
                Email = "bbbb@myclinic.com"
            };
            doctor = new Doctor
            {
                Id = 999999,
                Status = true,
                FirstName = "Goran",
                LastName = "Goranovic",
                PersonalNumber = "0000000000000",
                PhoneNumber = "0600000000",
                DateEmployed = Convert.ToDateTime("1975-01-01"),
                Specialization = "psychology",
                Department = "psychiatry",
                Email = "xxxx@gmail.com",
                Password = "Password1@"
            };
            adminRepository = new AdminRepository();
        }
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}