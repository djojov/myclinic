using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace DoctorBusinessTests
{
    [TestClass]
    public class DoctorBusinessTests
    {
        private Mock<IDoctorRepository> mockDoctorRepository = new Mock<IDoctorRepository>();

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
        private Patient patient1 = new Patient
        {
            Id = 999999,
            FirstName = "Boban",
            LastName = "Bobanovic",
            PersonalNumber = "2222222222222",
            HealthInsuranceNumber = "22222222222",
            DateOfBirth = Convert.ToDateTime("1975-01-01"),
            PlaceOfBirth = "Boljevac",
            Email="somemail@gmail.com",
            Password="Password123@",
            PhoneNumber="0699999999",
            Weight="100",
            Height="190"
        };
        private Patient patient2 = new Patient
        {
            Id = 1000000,
            FirstName = "Goran",
            LastName = "Goranovic",
            PersonalNumber = "2222222222223",
            HealthInsuranceNumber = "22222222223",
            DateOfBirth = Convert.ToDateTime("1975-01-01"),
            PlaceOfBirth = "Boljevac",
            Email = "somemail2@gmail.com",
            Password = "Password124@",
            PhoneNumber = "0699999991",
            Weight = "100",
            Height = "190"
        };
        private List<Patient> listOfPatients = new List<Patient>();
        private DoctorBusiness doctorBusiness;
        public DoctorBusinessTests()
        {
            listOfPatients.Add(patient1);
            listOfPatients.Add(patient2);
        }

        [TestMethod]
        public void GetAllPatientsTest()
        {
            mockDoctorRepository.Setup(x => x.GetAllPatients()).Returns(listOfPatients);
            this.doctorBusiness = new DoctorBusiness(mockDoctorRepository.Object);

            var result = doctorBusiness.GetAllPatients();

            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void isPatientInserted()
        {
            mockDoctorRepository.Setup(x => x.InsertPatient(patient1)).Returns(1);
            this.doctorBusiness = new DoctorBusiness(mockDoctorRepository.Object);

            var result = doctorBusiness.InsertPatient(patient1);

            Assert.AreEqual(result, "Patient successfully added!");
        }

        [TestMethod]
        public void isDoctorUpdatedTest()
        {
            mockDoctorRepository.Setup(x => x.UpdatePatient(patient1)).Returns(1);
            this.doctorBusiness = new DoctorBusiness(mockDoctorRepository.Object);

            var result = doctorBusiness.UpdatePatient(patient1);

            Assert.AreEqual(result, "Patient successfully updated!");
        }
        [TestMethod]
        public void ifGottenDoctorTest()
        {
            mockDoctorRepository.Setup(x => x.GetDoctor(doctor.Email, doctor.Password)).Returns(new Doctor
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
            });
            this.doctorBusiness = new DoctorBusiness(mockDoctorRepository.Object);

            var result = doctorBusiness.GetDoctor(doctor.Email, doctor.Password);

            Assert.AreEqual(result.Id, 99999);
        }
    }
}
