using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace AdminBusinessTests
{
    [TestClass]
    public class AdminBusinessTests
    {
        private Mock<IAdminRepository> mockAdminRepository = new Mock<IAdminRepository>();

        private Admin admin = new Admin
        {
            Id = 1,
            FirstName = "Marko",
            LastName = "Markovic",
            Email = "admin@myclinic.com",
            Password = "Adminadmin123@"
        };
        private Doctor doctor = new Doctor
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
        private Doctor doctor2 = new Doctor
        {
            Id = 100000,
            Status = true,
            FirstName = "Zoran",
            LastName = "Zoranovic",
            PersonalNumber = "0000000000001",
            PhoneNumber = "0600000001",
            DateEmployed = Convert.ToDateTime("1975-01-01"),
            Specialization = "psychology",
            Department = "psychiatry",
            Email = "xxxxxy@gmail.com",
            Password = "Password123@"
        };
        private List<Doctor> listOfDoctors = new List<Doctor>();
        private AdminBusiness adminBusiness;

        public AdminBusinessTests() 
        {
            listOfDoctors.Add(doctor);
            listOfDoctors.Add(doctor2);
        }

        [TestMethod]
        public void GetAllDoctorsTest()
        {
            mockAdminRepository.Setup(x => x.GetAllDoctors()).Returns(listOfDoctors);
            this.adminBusiness = new AdminBusiness(mockAdminRepository.Object);

            var result = adminBusiness.GetAllDoctors();

            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void IsDoctorInserted()
        {
            mockAdminRepository.Setup(x => x.InsertDoctor(doctor)).Returns(1);
            this.adminBusiness = new AdminBusiness(mockAdminRepository.Object);

            var result = adminBusiness.InsertDoctor(doctor);

            Assert.AreEqual(result, "Doctor successfully added!");
        }
        [TestMethod]
        public void IsDoctorUpdated()
        {
            mockAdminRepository.Setup(x => x.UpdateDoctor(doctor)).Returns(1);
            this.adminBusiness = new AdminBusiness(mockAdminRepository.Object);

            var result = adminBusiness.UpdateDoctor(doctor);

            Assert.AreEqual(result, "Doctor successfully updated!");
        }

        [TestMethod]
        public void IfGottenAdmin()
        {
            mockAdminRepository.Setup(x => x.GetAdmin(admin.Email, admin.Password)).Returns(new Admin { 
                Id = 1,
                FirstName = "Marko",
                LastName = "Markovic",
                Email = "admin@myclinic.com",
                Password = "Adminadmin123@"
            }); 
            this.adminBusiness = new AdminBusiness(mockAdminRepository.Object);

            var result = adminBusiness.GetAdmin(admin.Email, admin.Password);

            Assert.AreEqual(result.Id,1);
        }




    }
}
