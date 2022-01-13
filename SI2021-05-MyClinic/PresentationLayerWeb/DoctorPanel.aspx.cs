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
    public partial class DoctorPanel : System.Web.UI.Page
    {
        private IAdminBusiness adminBusiness;
        private IDoctorBusiness doctorBusiness;
        private IPatientBusiness patientBusiness;
        public DoctorPanel() { }
        public DoctorPanel(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
        }
        public DoctorPanel(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
        }
        public DoctorPanel(IPatientBusiness _patientBusiness)
        {
            patientBusiness = _patientBusiness;
        }
        public DoctorPanel(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness, IPatientBusiness _patientBusiness)
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
            var doctor = (Doctor)Session["Doctor"];
            TextBox_FirstName.Text = doctor.FirstName;
            TextBox_LastName.Text = doctor.LastName;
            TextBox_PersonalNumber.Text = doctor.PersonalNumber;
            TextBox_PhoneNumber.Text = doctor.PhoneNumber;
            TextBox_DateEmployed.Text = doctor.DateEmployed.ToString();
            TextBox_Specialization.Text = doctor.Specialization;
            TextBox_Department.Text = doctor.Department;
            TextBox_Email.Text = doctor.Email;
        }

        protected void Button_PatientManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PatientManagement.aspx");
        }

        protected void Button_Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}