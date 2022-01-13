using DataLayer.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Linq;

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
            doctorRepository = new DoctorRepository();
            patientRepository = new PatientRepository();
        }
        [TestMethod]
        public void GetAllPatientsTest() 
        {
            doctorRepository.InsertPatient(patient);
            Assert.IsNotNull(doctorRepository.GetAllPatients());
        }
        [TestMethod]
        public void UpdatePatientTest()
        {
            doctorRepository.InsertPatient(patient);
            Patient newPatient = doctorRepository.GetAllPatients().Where(x => x.PersonalNumber == patient.PersonalNumber).ToList()[0];
            int result = doctorRepository.UpdatePatient(newPatient);
            Assert.IsTrue(result > 0);
        }

        [TestCleanup]
        public void Clean()
        {
            Patient newPatient = doctorRepository.GetAllPatients().Where(x => x.PersonalNumber == patient.PersonalNumber).OrderByDescending(x => x.Id).First();
            doctorRepository.DeletePatient(newPatient.Id);
        }
    }
}

