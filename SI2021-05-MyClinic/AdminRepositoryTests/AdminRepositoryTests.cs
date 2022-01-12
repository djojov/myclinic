using DataLayer;
using DataLayer.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
                Id = 1,
                FirstName = "Marko",
                LastName = "Markovic",
                Email = "admin@myclinic.com",
                Password= "Adminadmin123@"
            };
            doctor = new Doctor
            {
                Id = 99999,
                Status = true,
                FirstName = "Goran",
                LastName = "Goranovic",
                PersonalNumber = "0000000000000",
                PhoneNumber = "0600000000",
                DateEmployed = Convert.ToDateTime("1975-01-01"),
                Specialization = "psychology",
                Department = "psychiatry",
                Email = "xxxxxx@gmail.com",
                Password = "Password123@"
            };
            adminRepository = new AdminRepository();
            doctorRepository = new DoctorRepository();
        }
        [TestMethod]
        public void GetAllDoctorsTest()
        {
            adminRepository.InsertDoctor(doctor);
            Assert.IsNotNull(adminRepository.GetAllDoctors());
        }
        [TestMethod]

        public void UpdateDoctorTest()
        {
            adminRepository.InsertDoctor(doctor);
            Doctor newDoctor = adminRepository.GetAllDoctors().Where(x => x.PersonalNumber == doctor.PersonalNumber).ToList()[0];
            int result = adminRepository.UpdateDoctor(newDoctor);
            Assert.IsTrue(result > 0);

        }
        [TestMethod]

        public void InsertDoctorTest()
        { 
            int result = adminRepository.InsertDoctor(doctor);
            Assert.IsTrue(result > 0);

        }
        [TestMethod]
        public void GetAdminTest()
        {
            adminRepository.InsertDoctor(doctor);
            Admin newAdmin = adminRepository.GetAdmin("admin@myclinic.com", "Adminadmin123@");
            Assert.AreEqual(newAdmin.Id, admin.Id);
            Assert.AreEqual(newAdmin.FirstName, admin.FirstName);
            Assert.AreEqual(newAdmin.LastName, admin.LastName);
            Assert.AreEqual(newAdmin.Email, admin.Email);
            Assert.AreEqual(newAdmin.Password, admin.Password);

        }

        [TestCleanup]
        public void Clean()
        {
            Doctor newDoctor = adminRepository.GetAllDoctors().Where(x => x.PersonalNumber == doctor.PersonalNumber).OrderByDescending(x=>x.Id).First();
            adminRepository.DeleteDoctor(newDoctor.Id);
        }
    }
}