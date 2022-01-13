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
                if (Session["Doctor"] == null)
                {
                    Response.Redirect("~/Login.aspx");
                }
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
            
            TextBox_PFirstName.Text = gvr.Cells[2].Text;
            TextBox_PLastName.Text = gvr.Cells[3].Text;

            TextBox_ViewReports.Text = "";
            TextBox_ViewReports.Visible = false;
        }

        protected void Button_UpdatePatient_Click(object sender, EventArgs e)
        {
            if (TextBox_Id.Text == "" || TextBox_FirstName.Text == "" || TextBox_LastName.Text == "" || TextBox_PersonalNumber.Text == "" ||
                TextBox_PhoneNumber.Text == "" || TextBox_HealthInsuranceNumber.Text == "" || TextBox_PlaceOfBirth.Text == "" ||
                TextBox_DateOfBirth.Text == "" || TextBox_Weight.Text == "" || TextBox_Height.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have to fill out all of the fields')", true);
            }
            else
            {
                Patient patient = new Patient();
                patient.Id = Convert.ToInt32(TextBox_Id.Text);
                patient.FirstName = TextBox_FirstName.Text;
                patient.LastName = TextBox_LastName.Text;
                patient.PersonalNumber = TextBox_PersonalNumber.Text;
                patient.PhoneNumber = TextBox_PhoneNumber.Text;
                patient.HealthInsuranceNumber = TextBox_HealthInsuranceNumber.Text;
                patient.PlaceOfBirth = TextBox_PlaceOfBirth.Text;
                patient.DateOfBirth = DateTime.Parse(TextBox_DateOfBirth.Text);
                patient.Weight = TextBox_Weight.Text;
                patient.Height = TextBox_Height.Text;
                string result = doctorBusiness.UpdatePatient(patient);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + result + "')", true);
            }
        }

        protected void Button_InsertPatientReport_Click(object sender, EventArgs e)
        {
            if (TextBox_Id.Text == "" || TextBox_FirstName.Text == "" || TextBox_LastName.Text == "" || TextBox_PersonalNumber.Text == "" ||
                TextBox_PhoneNumber.Text == "" || TextBox_HealthInsuranceNumber.Text == "" || TextBox_PlaceOfBirth.Text == "" ||
                TextBox_DateOfBirth.Text == "" || TextBox_Weight.Text == "" || TextBox_Height.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have to select a patient!')", true);
            }
            else
            {
                Patient patient = new Patient();
                patient.Id = Convert.ToInt32(TextBox_Id.Text);

                var doctor = (Doctor)Session["Doctor"];
                Session["doctorId"] = doctor.Id;
                string diagnosis = Convert.ToString(TextArea_PDiagnosis.Value);
                string result = doctorBusiness.InsertReport(Convert.ToInt32(Session["doctorId"]), patient.Id, diagnosis);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + result + "')", true);
                TextArea_PDiagnosis.Value = "";
            }
        }

        protected void Button_InsertPatient_Click(object sender, EventArgs e)
        {
            string url = "InsertPatient.aspx";
            string s = "window.open('" + url + "', 'popup_window', 'width=1024,height=800,left=100,top=100,resizable=yes');";
            ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
        }

        protected void Button_Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }

        protected void Button_ViewReports_Click(object sender, EventArgs e)
        {
            if (TextBox_Id.Text == "" || TextBox_FirstName.Text == "" || TextBox_LastName.Text == "" || TextBox_PersonalNumber.Text == "" ||
                TextBox_PhoneNumber.Text == "" || TextBox_HealthInsuranceNumber.Text == "" || TextBox_PlaceOfBirth.Text == "" ||
                TextBox_DateOfBirth.Text == "" || TextBox_Weight.Text == "" || TextBox_Height.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have to select a patient!')", true);
            }
            else
            {
                Patient patient = new Patient();
                patient.Id = Convert.ToInt32(TextBox_Id.Text);

                TextBox_ViewReports.Visible = true;
                List<string> reportList = patientBusiness.GetReportData(patient.Id);
                
                foreach(String s in reportList)
                {
                    TextBox_ViewReports.Text = String.Join(Environment.NewLine, reportList);
                }
            }
        }
    }
}