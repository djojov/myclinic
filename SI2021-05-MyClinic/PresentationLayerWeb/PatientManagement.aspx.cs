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
    public partial class PatientManagement : System.Web.UI.Page
    {
        private IAdminBusiness adminBusiness;
        private IDoctorBusiness doctorBusiness;
        private IPatientBusiness patientBusiness;
        public PatientManagement() { }
        public PatientManagement(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
        }
        public PatientManagement(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
        }
        public PatientManagement(IPatientBusiness _patientBusiness)
        {
            patientBusiness = _patientBusiness;
        }
        public PatientManagement(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness, IPatientBusiness _patientBusiness)
        {
            adminBusiness = _adminBusiness;
            doctorBusiness = _doctorBusiness;
            patientBusiness = _patientBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var doctor = (Doctor)Session["Doctor"];
                List<Patient> patientList = doctorBusiness.GetAllPatients();
                GridView_PatientList.DataSource = patientList;
                GridView_PatientList.DataBind();
            }
        }

        protected void Button_SelectPatient_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;

            TextBox_Id.Text = gvr.Cells[1].Text;
            TextBox_FirstName.Text = gvr.Cells[2].Text;
            TextBox_LastName.Text = gvr.Cells[3].Text;
            TextBox_PersonalNumber.Text = gvr.Cells[4].Text;
            TextBox_HealthInsuranceNumber.Text = gvr.Cells[5].Text;
            TextBox_DateOfBirth.Text = gvr.Cells[6].Text;
            TextBox_PlaceOfBirth.Text = gvr.Cells[7].Text;
            TextBox_PhoneNumber.Text = gvr.Cells[10].Text;
            TextBox_Weight.Text = gvr.Cells[11].Text;
            TextBox_Height.Text = gvr.Cells[12].Text;
        }

        protected void Button_UpdatePatient_Click(object sender, EventArgs e)
        {

        }
    }
}