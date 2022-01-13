using DataLayer.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PatientRepositoryTests
{
    [TestClass]
    public class PatientRepositoryTests
    {
        public Doctor doctor;
        public IDoctorRepository doctorRepository;

        public Patient patient;
        public IPatientRepository patientRepository;
        [TestInitialize]
        public void Init()
        {
            patient = new Patient
            {
                Id = 999999,
                FirstName = "Boban",
                LastName = "Bobanovic",
                PersonalNumber = "2222222222222",
                HealthInsuranceNumber = "22222222222",
                DateOfBirth = Convert.ToDateTime("1975-01-01"),
                PlaceOfBirth = "Boljevac",
                Email = "somemail@gmail.com",
                Password = "Password123@",
                PhoneNumber = "0688888888",
                Weight = "100",
                Height = "190"
            };
            doctorRepository = new DoctorRepository();
            patientRepository = new PatientRepository();
        }
        [TestMethod]
        public void GetPatientTest()
        {
            Patient patient1 = new Patient
            {
                Id = 999999,
                FirstName = "Boban",
                LastName = "Bobanovic",
                PersonalNumber = "2222222222222",
                HealthInsuranceNumber = "22222222222",
                DateOfBirth = Convert.ToDateTime("1975-01-01"),
                PlaceOfBirth = "Boljevac",
                Email = "somemail@gmail.com",
                Password = "Password123@",
                PhoneNumber = "0699999999",
                Weight = "100",
                Height = "190"
            };
            doctorRepository.InsertPatient(patient1);
            Patient patient = patientRepository.GetPatient("urosmilosevic@myclinic.com", "Password123@");
            Assert.AreEqual(patient.Id, patient.Id);
            Assert.AreEqual(patient.FirstName, patient.FirstName);
            Assert.AreEqual(patient.LastName, patient.LastName);
            Assert.AreEqual(patient.PersonalNumber, patient.PersonalNumber);
            Assert.AreEqual(patient.HealthInsuranceNumber, patient.HealthInsuranceNumber);
            Assert.AreEqual(patient.DateOfBirth, patient.DateOfBirth);
            Assert.AreEqual(patient.PlaceOfBirth, patient.PlaceOfBirth);
            Assert.AreEqual(patient.Email, patient.Email);
            Assert.AreEqual(patient.Password, patient.Password);
            Assert.AreEqual(patient.PhoneNumber, patient.PhoneNumber);
            Assert.AreEqual(patient.Weight, patient.Weight);
            Assert.AreEqual(patient.Height, patient.Height);
        }
        [TestMethod]
        public void GetReportDataTest()
        {
            doctorRepository.InsertPatient(patient);
            List<string> result = patientRepository.GetReportData(3);
            Assert.IsNotNull(result[0]);
        }
        [TestCleanup]
        public void Clean()
        {
            Patient newPatient = doctorRepository.GetAllPatients().Where(x => x.PersonalNumber == patient.PersonalNumber).OrderByDescending(x => x.Id).First();
            doctorRepository.DeletePatient(newPatient.Id);
        }
    }
}
