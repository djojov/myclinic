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
    public partial class Management : System.Web.UI.Page
    {
        private IAdminBusiness adminBusiness;
        private IDoctorBusiness doctorBusiness;
        private IPatientBusiness patientBusiness;
        public Management() { }
        public Management(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
        }
        public Management(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
        }
        public Management(IPatientBusiness _patientBusiness)
        {
            patientBusiness = _patientBusiness;
        }
        public Management(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness, IPatientBusiness _patientBusiness)
        {
            adminBusiness = _adminBusiness;
            doctorBusiness = _doctorBusiness;
            patientBusiness = _patientBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Patient"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            var patient = (Patient)Session["Patient"];
            TextBox_Id.Text = Convert.ToString(patient.Id);
            TextBox_PhoneNumber.Text = patient.PhoneNumber;
            TextBox_Weight.Text = patient.Weight;
            TextBox_Height.Text = patient.Height;
            TextBox_Email.Text = patient.Email;
            TextBox_Password.Text = patient.Password;
        }

        protected void Button_UpdateSelf_Click(object sender, EventArgs e)
        {
            if (TextBox_Height.Text == "" || TextBox_Weight.Text == "" || TextBox_PhoneNumber.Text == "" || TextBox_Password.Text == "" || TextBox_Email.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have to fill out all of the fields')", true);
            }
            else
            {
                Patient patient = new Patient();
                patient.Id = Convert.ToInt32(TextBox_Id.Text);
                patient.PhoneNumber = TextBox_PhoneNumber.Text;
                patient.Weight = TextBox_Weight.Text;
                patient.Height = TextBox_Height.Text;
                patient.Email = TextBox_Email.Text;
                patient.Password = TextBox_Password.Text;

                string result = patientBusiness.UpdateSelf(patient);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + result + "')", true);
            }
        }

        protected void Button_Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}