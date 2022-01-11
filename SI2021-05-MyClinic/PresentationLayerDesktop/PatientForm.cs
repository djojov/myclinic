using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerDesktop
{
    public partial class PatientForm : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IDoctorBusiness doctorBusiness;
        private readonly IPatientBusiness patientBusiness;
        Patient patient;
        public PatientForm(IPatientBusiness _patientBusiness, Patient _patient)
        {
            patientBusiness = _patientBusiness;
            patient = _patient;
            InitializeComponent();
        }
        public LoginForm RefLoginForm { get; set; }
        private void PatientForm_Load(object sender, EventArgs e)
        {
            textBox_FirstName.Text = patient.FirstName;
            textBox_LastName.Text = patient.LastName;
            textBox_PersonalNumber.Text = patient.PersonalNumber;
            textBox_HealthInsuranceNumber.Text = patient.HealthInsuranceNumber;
            textBox_DateOfBirth.Text = patient.DateOfBirth.ToString();
            textBox_PlaceOfBirth.Text = patient.PlaceOfBirth;
            textBox_PhoneNumber.Text = patient.PhoneNumber;
            textBox_Weight.Text = patient.Weight;
            textBox_Height.Text = patient.Height;
            textBox_Email.Text = patient.Email;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.RefLoginForm.Show();
            this.Close();
        }

        private void button_ReportView_Click(object sender, EventArgs e)
        {
            ReportViewForm viewReportForm = new ReportViewForm(patientBusiness, patient, null);
            viewReportForm.RefPatientForm = this;
            viewReportForm.Show();
        }

        private void button_UpdateData_Click(object sender, EventArgs e)
        {
            if (textBox_PhoneNumber.Text == "" || textBox_Height.Text == "" || textBox_Weight.Text == "" ||
                textBox_Email.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PhoneNumber.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                MessageBox.Show("E-mail entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Email.Focus();
                return;
            }
            else if (textBox_Password.Text != "" || textBox_NewPassword.Text != "")
            {
                if (!Regex.Match(textBox_Password.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$").Success)
                {
                    MessageBox.Show("Password entered incorrectly!\nYour password has to contain at least 8 characters, one uppercase and one lowercase letter and one special character!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Password.Text = "";
                    textBox_NewPassword.Text = "";
                    textBox_Password.Focus();
                    return;
                }
                else if (textBox_Password.Text != textBox_NewPassword.Text)
                {
                    MessageBox.Show("Your confirmation password does not match your password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Password.Text = "";
                    textBox_NewPassword.Text = "";
                    textBox_Password.Focus();
                    return;
                }
                else
                {
                    patient.Password = patient.Password;
                }
            }
            else if (!Regex.Match(textBox_PhoneNumber.Text, @"^[0][6]\d{1}[1-9]\d{2,3}\d{3,4}$").Success)
            {
                MessageBox.Show("Phone number entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PhoneNumber.Focus();
                return;
            }
            else if (textBox_Password.Text != textBox_NewPassword.Text)
            {
                MessageBox.Show("Your confirmation password does not match your password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Password.Text = "";
                textBox_NewPassword.Text = "";
                textBox_Password.Focus();
                return;
            }
            patient.PhoneNumber = textBox_PhoneNumber.Text;
            patient.Weight = textBox_Weight.Text;
            patient.Height = textBox_Height.Text;
            patient.Email = textBox_Email.Text;
            if(textBox_Password.Text == "" && textBox_NewPassword.Text == "")
            {
                patient.Password = patient.Password;
            }
            string result = patientBusiness.UpdateSelf(patient);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
