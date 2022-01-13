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
    public partial class PatientManagementForm : Form
    {
        IDoctorBusiness doctorBusiness;
        IPatientBusiness patientBusiness;
        Doctor doctor;
        public PatientManagementForm(IDoctorBusiness _doctorBusiness, IPatientBusiness _patientBusiness, Doctor _doctor)
        {
            doctorBusiness = _doctorBusiness;
            patientBusiness = _patientBusiness;
            doctor = _doctor;
            InitializeComponent();
        }
        public DoctorForm RefDoctorForm { get; set; }

        private void PatientManagementForm_Load(object sender, EventArgs e)
        {
            List<Patient> patientList = doctorBusiness.GetAllPatients();
            dataGridView_PatientList.DataSource = patientList;
            dataGridView_PatientList.Columns[7].Visible = false;
            dataGridView_PatientList.Columns[8].Visible = false;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.RefDoctorForm.Show();
            this.Close();
        }

        private void dataGridView_PatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView_PatientList.Rows[e.RowIndex];
                textBox_FirstName.Text = row.Cells[1].Value.ToString();
                textBox_LastName.Text = row.Cells[2].Value.ToString();
                textBox_PersonalNumber.Text = row.Cells[3].Value.ToString();
                textBox_HealthInsuranceNumber.Text = row.Cells[4].Value.ToString();
                dateTimePicker_DateOfBirth.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
                textBox_PlaceOfBirth.Text = row.Cells[6].Value.ToString();
                textBox_PhoneNumber.Text = row.Cells[9].Value.ToString();
                textBox_Weight.Text = row.Cells[10].Value.ToString();
                textBox_Height.Text = row.Cells[11].Value.ToString();
            }
        }

        private void button_UpdatePatient_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "" || textBox_LastName.Text == "" || textBox_PersonalNumber.Text == "" ||
                textBox_PhoneNumber.Text == "" || textBox_HealthInsuranceNumber.Text == "" || textBox_PlaceOfBirth.Text == ""
                || textBox_Height.Text == "" || textBox_Height.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_FirstName.Text, @"^[A-Z]+[A-Za-z\s]{1,15}([A-Z]?)+([A-Za-z\s]?)$").Success)
            {
                MessageBox.Show("First name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_LastName.Text, @"^[A-Z]+[A-Za-z\s-]{1,30}([A-Z]?)+([A-Za-z\s]?)$").Success)
            {
                MessageBox.Show("Last name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_LastName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_PhoneNumber.Text, @"^[0][6]\d{7,8}$").Success)
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
            else if (!Regex.Match(textBox_PlaceOfBirth.Text, @"^[A-Z]+[A-Za-z\s]{1,20}([A-Z]?)+([A-Za-z\s]?)$").Success)
            {
                MessageBox.Show("Place of birth cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PlaceOfBirth.Focus();
                return;
            }
            else if(dateTimePicker_DateOfBirth.Value == DateTime.Now)
            {
                MessageBox.Show("Date of birth entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker_DateOfBirth.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Weight.Text, @"^[1-9]{0,1}[0-9]{1,2}$").Success)
            {
                MessageBox.Show("Weight cannot contain anything else but digits!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Weight.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Height.Text, @"^[1-9]{0,1}[0-9]{1,2}$").Success)
            {
                MessageBox.Show("Height cannot contain anything else but digits!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Height.Focus();
                return;
            }
            Patient patient = new Patient();
            patient.FirstName = textBox_FirstName.Text;
            patient.LastName = textBox_LastName.Text;
            patient.PersonalNumber = textBox_PersonalNumber.Text;
            patient.HealthInsuranceNumber = textBox_HealthInsuranceNumber.Text;
            patient.DateOfBirth= dateTimePicker_DateOfBirth.Value;
            patient.PlaceOfBirth = textBox_PlaceOfBirth.Text;
            patient.PhoneNumber= textBox_PhoneNumber.Text;
            patient.Weight = textBox_Weight.Text;
            patient.Height = textBox_Height.Text;
            List<Patient> temp = doctorBusiness.GetAllPatients().Where(person => person.PersonalNumber == textBox_PersonalNumber.Text).ToList();
            patient.Password = temp[0].Password;
            patient.Email = temp[0].Email;
            patient.Id = temp[0].Id;
            string result = doctorBusiness.UpdatePatient(patient);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView_PatientList.DataSource = doctorBusiness.GetAllPatients();
            dataGridView_PatientList.Columns[7].Visible = false;
            dataGridView_PatientList.Columns[8].Visible = false;
        }

        private void button_InsertPatient_Click(object sender, EventArgs e)
        {
            InsertPatientForm insertPatientForm = new InsertPatientForm(doctorBusiness);
            insertPatientForm.RefPatientManagementForm = this;
            insertPatientForm.FormClosed += new FormClosedEventHandler(FormClose);
            insertPatientForm.Show();
        }
        private void FormClose(object sender, EventArgs e)
        {
            dataGridView_PatientList.DataSource = doctorBusiness.GetAllPatients();
            dataGridView_PatientList.Columns[7].Visible = false;
            dataGridView_PatientList.Columns[8].Visible = false;
            this.Refresh();
        }

        private void button_InsertReport_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.FirstName = textBox_FirstName.Text;
            patient.LastName = textBox_LastName.Text;
            patient.PersonalNumber = textBox_PersonalNumber.Text;
            patient.HealthInsuranceNumber = textBox_HealthInsuranceNumber.Text;
            patient.DateOfBirth = dateTimePicker_DateOfBirth.Value;
            patient.PlaceOfBirth = textBox_PlaceOfBirth.Text;
            patient.PhoneNumber = textBox_PhoneNumber.Text;
            patient.Weight = textBox_Weight.Text;
            patient.Height = textBox_Height.Text;

            if (textBox_FirstName.Text == "" || textBox_LastName.Text == "" || textBox_PersonalNumber.Text == "" ||
                textBox_PhoneNumber.Text == "" || textBox_HealthInsuranceNumber.Text == "" || textBox_PlaceOfBirth.Text == ""
                || textBox_Height.Text == "" || textBox_Height.Text == "")
            {
                MessageBox.Show("You have to select a patient!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Patient> temp = doctorBusiness.GetAllPatients().Where(person => person.PersonalNumber == textBox_PersonalNumber.Text).ToList();
            patient.Password = temp[0].Password;
            patient.Email = temp[0].Email;
            patient.Id = temp[0].Id;

            if(patient == null)
            {
                MessageBox.Show("You have to select a patient!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InsertReportForm insertReportForm = new InsertReportForm(doctorBusiness, doctor, patient);
            insertReportForm.RefPatientManagementForm = this;
            insertReportForm.Show();
        }

        private void button_ViewReport_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.FirstName = textBox_FirstName.Text;
            patient.LastName = textBox_LastName.Text;
            patient.PersonalNumber = textBox_PersonalNumber.Text;
            patient.HealthInsuranceNumber = textBox_HealthInsuranceNumber.Text;
            patient.DateOfBirth = dateTimePicker_DateOfBirth.Value;
            patient.PlaceOfBirth = textBox_PlaceOfBirth.Text;
            patient.PhoneNumber = textBox_PhoneNumber.Text;
            patient.Weight = textBox_Weight.Text;
            patient.Height = textBox_Height.Text;

            if (textBox_FirstName.Text == "" || textBox_LastName.Text == "" || textBox_PersonalNumber.Text == "" ||
                textBox_PhoneNumber.Text == "" || textBox_HealthInsuranceNumber.Text == "" || textBox_PlaceOfBirth.Text == ""
                || textBox_Height.Text == "" || textBox_Height.Text == "")
            {
                MessageBox.Show("You have to select a patient!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Patient> temp = doctorBusiness.GetAllPatients().Where(person => person.PersonalNumber == textBox_PersonalNumber.Text).ToList();
            patient.Password = temp[0].Password;
            patient.Email = temp[0].Email;
            patient.Id = temp[0].Id;

            ReportViewForm viewReportForm = new ReportViewForm(patientBusiness, patient, doctor);
            viewReportForm.RefPatientManagementForm = this;
            viewReportForm.Show();

        }
    }
}
