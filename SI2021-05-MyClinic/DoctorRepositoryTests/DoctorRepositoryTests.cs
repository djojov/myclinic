using DataLayer.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Interfaces;
using Shared.Models;
using System;

namespace DoctorRepositoryTests
{
    [TestClass]
    public class DoctorRepositoryTests
    {
        public Doctor doctor;
        public IDoctorRepository doctorRepository;

        public Patient patient;
        public IPatientRepository patientRepository;
        [TestInitialize]
        public void init()
        {
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
            patient = new Patient
            {
                Id = 99999999,
                FirstName = "Boban",
                LastName = "Bobanovic",
                PersonalNumber = "1111111111111",
                HealthInsuranceNumber = "22222222222",
                DateOfBirth = Convert.ToDateTime("1975-01-01"),
                PlaceOfBirth = "Boljevac",
                Email="somemail@gmail.com",
                Password="Password123@",
                PhoneNumber="0699999999",
                Weight="100",
                Height="190"
            };
            doctorRepository = new DoctorRepository();
            patientRepository = new PatientRepository();
        }
        [TestMethod]
        public void GetAllPatientsTest() 
        {
            Assert.IsNotNull(doctorRepository.GetAllPatients());
        }
    }
}

