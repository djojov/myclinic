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
    public partial class InsertDoctorForm : Form
    {
        private readonly IAdminBusiness adminBusiness;
        public InsertDoctorForm(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
            InitializeComponent();
        }

        private void InsertDoctorForm_Load(object sender, EventArgs e)
        {

        }
        public DoctorManagementForm RefDoctorManagementForm { get; set; }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "" || textBox_LastName.Text == "" || textBox_PersonalNumber.Text == "" ||
                textBox_PhoneNumber.Text == "" || textBox_Specialization.Text == "" || textBox_Department.Text == "" || 
                textBox_Email.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBox_Email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                MessageBox.Show("E-mail entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Email.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Password.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$").Success)
            {
                MessageBox.Show("Password entered incorrectly!\nYour password has to contain at least 8 characters, one uppercase and one lowercase letter and one special character!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Password.Focus();
                return;
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
            else if (!Regex.Match(textBox_PersonalNumber.Text, @"^(\d{9})?$").Success)
            {
                MessageBox.Show("Personal number entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PersonalNumber.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Specialization.Text, @"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$").Success)
            {
                MessageBox.Show("Specialization cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Specialization.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Department.Text, @"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$").Success)
            {
                MessageBox.Show("Department cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Department.Focus();
                return;
            }
            else
            {
                Doctor doctor = new Doctor();
                doctor.FirstName = textBox_FirstName.Text;
                doctor.LastName = textBox_LastName.Text;
                doctor.PhoneNumber = textBox_PhoneNumber.Text;
                doctor.PersonalNumber = textBox_PersonalNumber.Text;
                doctor.DateEmployed = dateTimePicker_DateEmployed.Value;
                doctor.Specialization = textBox_Specialization.Text;
                doctor.Department = textBox_Department.Text;
                doctor.Email = textBox_Email.Text;
                doctor.Password = textBox_Password.Text;
                string result = adminBusiness.InsertDoctor(doctor);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_PhoneNumber.Text = "";
                textBox_PersonalNumber.Text = "";
                dateTimePicker_DateEmployed.Value = DateTime.Now;
                textBox_Specialization.Text = "";
                textBox_Department.Text = "";
                textBox_Email.Text = "";
                textBox_Password.Text = "";
            }
        }

       
    }
}
