using DataLayer.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Interfaces;
using Shared.Models;
using System;

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
        public void init() 
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
                PhoneNumber = "0699999999",
                Weight = "100",
                Height = "190"
            };
            patientRepository = new PatientRepository();
            doctorRepository = new DoctorRepository();
        }
       
    }
}
