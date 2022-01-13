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
            Weight = "100",
            Height = "190"
        };
        private PatientBusiness patientBusiness;

    }
}
