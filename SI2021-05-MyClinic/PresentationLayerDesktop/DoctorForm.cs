using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerDesktop
{
    public partial class DoctorForm : Form
    {
        IAdminBusiness adminBusiness;
        private readonly IDoctorBusiness doctorBusiness;
        private readonly IPatientBusiness patientBusiness;
        Doctor doctor;
        public DoctorForm(IDoctorBusiness _doctorBusiness , IPatientBusiness _patientBusiness, Doctor _doctor)
        {
            doctorBusiness = _doctorBusiness;
            patientBusiness = _patientBusiness;
            doctor = _doctor;
            InitializeComponent();
        }
        public LoginForm RefLoginForm { get; set; }
        private void DoctorForm_Load(object sender, EventArgs e)
        {
            textBox_FirstName.Text = doctor.FirstName;
            textBox_LastName.Text = doctor.LastName;
            textBox_PersonalNumber.Text = doctor.PersonalNumber;
            textBox_PhoneNumber.Text = doctor.PhoneNumber;
            textBox_DateEmployed.Text = doctor.DateEmployed.ToString();
            textBox_Specialization.Text = doctor.Specialization;
            textBox_Department.Text = doctor.Department;
            textBox_Email.Text = doctor.Email;
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            this.RefLoginForm.Show();
            this.Close();
        }

        private void button_PatientManagement_Click(object sender, EventArgs e)
        {
            PatientManagementForm patientManagementForm = new PatientManagementForm(doctorBusiness, patientBusiness);
            patientManagementForm.RefDoctorForm = this;
            patientManagementForm.Show();
            this.Hide();
        }
    }
}
