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
    public partial class InsertReportForm : Form
    {
        Patient patient;
        Doctor doctor;
        IDoctorBusiness doctorBusiness;
        public InsertReportForm(IDoctorBusiness _doctorBusiness, Doctor _doctor, Patient _patient)
        {
            doctorBusiness = _doctorBusiness;
            doctor = _doctor;
            patient = _patient;
            InitializeComponent();
        }
        public PatientManagementForm RefPatientManagementForm{get; set; }
        private void InsertReportForm_Load(object sender, EventArgs e)
        {
            textBox_PatientFullName.Text = patient.FirstName + " " + patient.LastName;
            textBox_PatientPersonalNumber.Text = patient.PersonalNumber;
            textBox_Date.Text = DateTime.Now.ToString();
            richTextBox_Diagnosis.Focus();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_InsertNewReport_Click(object sender, EventArgs e)
        {
            if(richTextBox_Diagnosis.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox_Diagnosis.Focus();
                return;
            }
            else if (!Regex.Match(richTextBox_Diagnosis.Text, @"^[a-zA-Z\s-.,0-9]{1,200}$").Success)
            {
                MessageBox.Show("Diagnosis entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox_Diagnosis.Focus();
                return;
            }
            string result = doctorBusiness.InsertReport(doctor.Id, patient.Id, richTextBox_Diagnosis.Text);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            richTextBox_Diagnosis.Text = "";
        }
    }
}
