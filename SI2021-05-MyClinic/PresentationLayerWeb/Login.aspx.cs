using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared.Interfaces;

namespace PresentationLayerWeb
{
    public partial class Login : System.Web.UI.Page
    {
        private IAdminBusiness adminBusiness;
        private IDoctorBusiness doctorBusiness;
        private IPatientBusiness patientBusiness;
        public Login() { }
        public Login(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
        }
        public Login(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
        }
        public Login(IPatientBusiness _patientBusiness)
        {
            patientBusiness = _patientBusiness;
        }
        public Login(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness, IPatientBusiness _patientBusiness)
        {
            adminBusiness = _adminBusiness;
            doctorBusiness = _doctorBusiness;
            patientBusiness = _patientBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }



        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            if (login_email.Value == "" || login_password.Value == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have to enter e-mail and password!')", true);
            }

            if (DropDownList_LoginType.SelectedItem.ToString() == "Admin")
            {
                Admin admin = adminBusiness.GetAdmin(Convert.ToString(login_email.Value), Convert.ToString(login_password.Value));
                if(admin.Id == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('There is no admin with that e-mail and password')", true);

                }
                else
                {
                    Session["Admin"] = admin;
                    Response.Redirect("~/AdminPanel.aspx");
                }

            }
            if (DropDownList_LoginType.SelectedItem.ToString() == "Doctor")
            {
                Doctor doctor = doctorBusiness.GetDoctor(Convert.ToString(login_email.Value), Convert.ToString(login_password.Value));
                if (doctor.Id == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('There is no doctor with that e-mail and password')", true);

                }
                else
                {
                    Session["Doctor"] = doctor;
                    Response.Redirect("~/DoctorPanel.aspx");
                }

            }
            if (DropDownList_LoginType.SelectedItem.ToString() == "Patient")
            {
                Patient patient = patientBusiness.GetPatient(Convert.ToString(login_email.Value), Convert.ToString(login_password.Value));
                if (patient.Id == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('There is no patient with that e-mail and password')", true);

                }
                else
                {
                    Session["Patient"] = patient;
                    Response.Redirect("~/PatientPanel.aspx");
                }

            }
            if(DropDownList_LoginType.SelectedItem.ToString() == "Select login type")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You must select login type!')", true);
            }
        }
    }
}