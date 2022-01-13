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
    public partial class InsertPatient : System.Web.UI.Page
    {
        private IAdminBusiness adminBusiness;
        private IDoctorBusiness doctorBusiness;
        private IPatientBusiness patientBusiness;
        public InsertPatient() { }
        public InsertPatient(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
        }
        public InsertPatient(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
        }
        public InsertPatient(IPatientBusiness _patientBusiness)
        {
            patientBusiness = _patientBusiness;
        }
        public InsertPatient(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness, IPatientBusiness _patientBusiness)
        {
            adminBusiness = _adminBusiness;
            doctorBusiness = _doctorBusiness;
            patientBusiness = _patientBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Doctor"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void Button_InsertPatient_Click(object sender, EventArgs e)
        {
            if (TextBox_FirstName.Text == "" || TextBox_LastName.Text == "" || TextBox_PersonalNumber.Text == "" ||
                TextBox_PhoneNumber.Text == "" || TextBox_HealthInsuranceNumber.Text == "" || TextBox_PlaceOfBirth.Text == "" ||
                TextBox_Email.Text == "" || TextBox_Height.Text == "" || TextBox_Weight.Text == "" || Input_DatePicker.Value == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have to fill out all of the fields')", true);
            }
            else
            {
                Patient patient = new Patient();
                patient.FirstName = TextBox_FirstName.Text;
                patient.LastName = TextBox_LastName.Text;
                patient.PersonalNumber = TextBox_PersonalNumber.Text;
                patient.PhoneNumber = TextBox_PhoneNumber.Text;
                patient.DateOfBirth = DateTime.Parse(Input_DatePicker.Value);
                patient.Email = TextBox_Email.Text;
                patient.HealthInsuranceNumber = TextBox_HealthInsuranceNumber.Text;
                patient.Weight = TextBox_Weight.Text;
                patient.Height = TextBox_Height.Text;
                patient.PlaceOfBirth = TextBox_PlaceOfBirth.Text;
                string result = doctorBusiness.InsertPatient(patient);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + result + "')", true);

                TextBox_FirstName.Text = "";
                TextBox_LastName.Text = "";
                TextBox_PersonalNumber.Text = "";
                TextBox_PhoneNumber.Text = "";
                TextBox_HealthInsuranceNumber.Text = "";
                TextBox_Email.Text = "";
                Input_DatePicker.Value = "";
                TextBox_PlaceOfBirth.Text = "";
                TextBox_Weight.Text = "";
                TextBox_Height.Text = "";
            }
        }

        protected void Button_Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}