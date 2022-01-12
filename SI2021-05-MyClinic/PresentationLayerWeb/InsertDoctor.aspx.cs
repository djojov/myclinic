using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    public partial class InsertDoctor : System.Web.UI.Page
    {
        private IAdminBusiness adminBusiness;
        private IDoctorBusiness doctorBusiness;
        private IPatientBusiness patientBusiness;
        public InsertDoctor() { }
        public InsertDoctor(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
        }
        public InsertDoctor(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
        }
        public InsertDoctor(IPatientBusiness _patientBusiness)
        {
            patientBusiness = _patientBusiness;
        }
        public InsertDoctor(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness, IPatientBusiness _patientBusiness)
        {
            adminBusiness = _adminBusiness;
            doctorBusiness = _doctorBusiness;
            patientBusiness = _patientBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        { 
        }

        protected void Button_InsertDoctor_Click(object sender, EventArgs e)
        {
            if (TextBox_FirstName.Text == "" || TextBox_LastName.Text == "" || TextBox_PersonalNumber.Text == "" ||
                TextBox_PhoneNumber.Text == "" || TextBox_Specialization.Text == "" || TextBox_Department.Text == "" ||
                TextBox_Email.Text == "" || TextBox_Password.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have to fill out all of the fields')", true);
            }
            else
            {
                Doctor doctor = new Doctor();
                doctor.FirstName = TextBox_FirstName.Text;
                doctor.LastName = TextBox_LastName.Text;
                doctor.PersonalNumber = TextBox_PersonalNumber.Text;
                doctor.PhoneNumber = TextBox_PhoneNumber.Text;
                doctor.Specialization = TextBox_Specialization.Text;
                doctor.Department = TextBox_Department.Text;
                doctor.DateEmployed = DateTime.Parse(Input_DatePicker.Value);
                doctor.Email = TextBox_Email.Text;
                doctor.Password = TextBox_Password.Text;
                string result = adminBusiness.InsertDoctor(doctor);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + result + "')", true);

                TextBox_FirstName.Text = "";
                TextBox_LastName.Text = "";
                TextBox_PersonalNumber.Text = "";
                TextBox_PhoneNumber.Text = "";
                TextBox_Specialization.Text = "";
                TextBox_Department.Text = "";
                Input_DatePicker.Value = Convert.ToString(DateTime.Now);
                TextBox_Email.Text = "";
                TextBox_Password.Text = "";
            }
        }
    }
}