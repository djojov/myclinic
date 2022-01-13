using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace PatientBusinessTests
{
    [TestClass]
    public class PatientBusinessTests
    {
        private Mock<IPatientRepository> mockPatientRepository = new Mock<IPatientRepository>();

        private Patient patient = new Patient
        {
            Id = 1000000,
            FirstName = "Goran",
            LastName = "Goranovic",
            PersonalNumber = "2222222222233",
            HealthInsuranceNumber = "22222222233",
            DateOfBirth = Convert.ToDateTime("1975-01-01"),
            PlaceOfBirth = "Boljevac",
            Email = "somemail22@gmail.com",
            Password = "Password124@",
            PhoneNumber = "0699999992",
            Weight = "40",
            Height = "190"
        };
        private PatientBusiness patientBusiness;
        [TestMethod]
        public void CalculateBMITest()
        {
            mockPatientRepository.Setup(x => x.CalculateBMI(patient.Weight, patient.Height)).Returns(1);
            this.patientBusiness = new PatientBusiness(mockPatientRepository.Object);

            var result = patientBusiness.CalculateBMI(patient.Weight, patient.Height);

            Assert.AreEqual("Underweight!", result);
        }
        [TestMethod]
        public void IfGotPatientTest()
        {
            mockPatientRepository.Setup(x => x.GetPatient(patient.Email, patient.Password)).Returns(new Patient
            {
                Id = 1000000,
                FirstName = "Goran",
                LastName = "Goranovic",
                PersonalNumber = "2222222222233",
                HealthInsuranceNumber = "22222222233",
                DateOfBirth = Convert.ToDateTime("1975-01-01"),
                PlaceOfBirth = "Boljevac",
                Email = "somemail22@gmail.com",
                Password = "Password124@",
                PhoneNumber = "0699999992",
                Weight = "40",
                Height = "190"
            });
            this.patientBusiness = new PatientBusiness(mockPatientRepository.Object);

            var result = patientBusiness.GetPatient(patient.Email, patient.Password);

            Assert.AreEqual(result.Id, 1000000);
        }
        [TestMethod]
        public void DidSelfUpdateTest()
        {
            mockPatientRepository.Setup(x => x.UpdateSelf(patient)).Returns(1);
            this.patientBusiness = new PatientBusiness(mockPatientRepository.Object);

            var result = patientBusiness.UpdateSelf(patient);

            Assert.AreEqual(result, "Successfully updated!");
        }
    }
}
