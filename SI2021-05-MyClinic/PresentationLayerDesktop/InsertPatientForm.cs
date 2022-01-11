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
    public partial class InsertPatientForm : Form
    {
        IDoctorBusiness doctorBusiness;
        public InsertPatientForm(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
            InitializeComponent();
        }
        public PatientManagementForm RefPatientManagementForm { get; set; }
        private void InsertPatientForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_InsertNewPatient_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "" || textBox_LastName.Text == "" || textBox_PersonalNumber.Text == "" ||
                textBox_PhoneNumber.Text == "" || textBox_HealthInsuranceNumber.Text == "" || textBox_PlaceOfBirth.Text == ""
                || textBox_Height.Text == "" || textBox_Height.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBox_FirstName.Text, @"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$").Success)
            {
                MessageBox.Show("First name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_LastName.Text, @"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$").Success)
            {
                MessageBox.Show("Last name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_LastName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_PhoneNumber.Text, @"^[0][6]\d{1}[1-9]\d{2,3}\d{3,4}$").Success)
            {
                MessageBox.Show("Phone number entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PhoneNumber.Focus();
                return;
            }
            else if (!Regex.Match(textBox_PersonalNumber.Text, @"^(\d{13})?$").Success)
            {
                MessageBox.Show("Personal number entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PersonalNumber.Focus();
                return;
            }
            else if (!Regex.Match(textBox_HealthInsuranceNumber.Text, @"^(\d{11})?$").Success)
            {
                MessageBox.Show("Health Insurance number entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_HealthInsuranceNumber.Focus();
                return;
            }
            else if (!Regex.Match(textBox_PlaceOfBirth.Text, @"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$").Success)
            {
                MessageBox.Show("Place of birth cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PlaceOfBirth.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                MessageBox.Show("E-mail entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Email.Focus();
                return;
            }
            Patient patient = new Patient();
            patient.FirstName = textBox_FirstName.Text;
            patient.LastName = textBox_LastName.Text;
            patient.PersonalNumber = textBox_PersonalNumber.Text;
            patient.HealthInsuranceNumber = textBox_HealthInsuranceNumber.Text;
            patient.DateOfBirth = dateTimePicker_DateOfBirth.Value;
            patient.PlaceOfBirth = textBox_PlaceOfBirth.Text;
            patient.PhoneNumber = textBox_PhoneNumber.Text;
            patient.Email = textBox_Email.Text;
            patient.Weight = textBox_Weight.Text;
            patient.Height = textBox_Height.Text;
            string result = doctorBusiness.InsertPatient(patient);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_FirstName.Text = "";
            textBox_LastName.Text = "";
            textBox_PersonalNumber.Text = "";
            textBox_HealthInsuranceNumber.Text = "";
            dateTimePicker_DateOfBirth.Value = DateTime.Now;
            textBox_PlaceOfBirth.Text = "";
            textBox_PhoneNumber.Text = "";
            textBox_Email.Text = "";
            textBox_Weight.Text = "";
            textBox_Height.Text = "";
            textBox_FirstName.Focus();
        }
    }
}
