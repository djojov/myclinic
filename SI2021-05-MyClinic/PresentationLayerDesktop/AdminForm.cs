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
    public partial class AdminForm : Form
    {
        private readonly IAdminBusiness adminBusiness;
        private readonly IDoctorBusiness doctorBusiness;
        private readonly IPatientBusiness patientBusiness;
        Admin admin;
        public AdminForm(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness, Admin _admin)
        {
            admin = _admin;
            adminBusiness = _adminBusiness;
            doctorBusiness = _doctorBusiness;
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            textBox_FirstName.Text = admin.FirstName;
            textBox_LastName.Text = admin.LastName;
            textBox_Email.Text = admin.Email;
            textBox_CurrentNumberPatients.Text = doctorBusiness.GetAllPatients().Count().ToString();
            textBox_CurrentNumberDoctors.Text = adminBusiness.GetAllDoctors().Count().ToString();
        }

        public LoginForm RefLoginForm { get; set; }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            this.RefLoginForm.Show();
            this.Close();
        }

        private void button_DoctorManagement_Click(object sender, EventArgs e)
        {
            DoctorManagementForm doctorManagementForm = new DoctorManagementForm(adminBusiness);
            doctorManagementForm.RefAdminForm = this;
            doctorManagementForm.Show();
            this.Hide(); 
        }
    }
}
