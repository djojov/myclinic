using BusinessLayer;
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
    public partial class LoginForm : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IDoctorBusiness doctorBusiness;
        private readonly IPatientBusiness patientBusiness;

        public LoginForm(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness, IPatientBusiness _patientBusiness)
        {
            adminBusiness = _adminBusiness;
            doctorBusiness = _doctorBusiness;
            patientBusiness = _patientBusiness;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_LoginAs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show("You have to enter e-mail and password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(textBox_Email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
                {
                    MessageBox.Show("E-mail entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Email.Focus();
                    return;
                }
            else if (!Regex.Match(textBox_Password.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$").Success)
            {
                MessageBox.Show("Password entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Password.Focus();
                return;
            }
            else {
                if (comboBox_LoginAs.SelectedItem.ToString() == "Admin")
                {
                    Admin admin = adminBusiness.GetAdmin(textBox_Email.Text, textBox_Password.Text);
                    if (admin.Id == 0 )
                    { 
                        MessageBox.Show("There is no admin with those e-mail and password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        AdminForm adminForm = new AdminForm(adminBusiness,doctorBusiness,admin);
                        adminForm.RefLoginForm = this;
                        //this.Visible = false;
                        this.Hide();
                        adminForm.Show();
                        comboBox_LoginAs.SelectedIndex = -1;
                        textBox_Email.Text = "";
                        textBox_Password.Text = "";
                        textBox_Email.Focus();
                    }
                }
                else if (comboBox_LoginAs.SelectedItem.ToString() == "Doctor")
                {
                    Doctor doctor = doctorBusiness.GetDoctor(textBox_Email.Text, textBox_Password.Text);
                    if (doctor.Id == 0)
                    {
                        MessageBox.Show("There is no doctor with those e-mail and password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DoctorForm doctorForm = new DoctorForm();
                        this.Hide();
                        doctorForm.Show();
                    }
                }
                else if (comboBox_LoginAs.SelectedItem.ToString() == "Patient")
                {
                    Patient patient = patientBusiness.GetPatient(textBox_Email.Text, textBox_Password.Text);
                    if (patient.Id == 0)
                    {
                        MessageBox.Show("There is no patient with those e-mail and password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        PatientForm patientForm = new PatientForm();
                        this.Hide();
                        patientForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("You have to choose login as", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
