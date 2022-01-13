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
    public partial class DoctorManagement : System.Web.UI.Page
    {
        private IAdminBusiness adminBusiness;
        private IDoctorBusiness doctorBusiness;
        private IPatientBusiness patientBusiness;
        public DoctorManagement() { }
        public DoctorManagement(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
        }
        public DoctorManagement(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
        }
        public DoctorManagement(IPatientBusiness _patientBusiness)
        {
            patientBusiness = _patientBusiness;
        }
        public DoctorManagement(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness, IPatientBusiness _patientBusiness)
        {
            adminBusiness = _adminBusiness;
            doctorBusiness = _doctorBusiness;
            patientBusiness = _patientBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Admin"] == null)
                {
                    Response.Redirect("~/Login.aspx");
                }
                var admin = (Admin)Session["Admin"];
                List<Doctor> doctorList = adminBusiness.GetAllDoctors();
                GridView_DoctorList.DataSource = doctorList;
                GridView_DoctorList.DataBind();
            }
        }
        protected void Button_SelectDoctor_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;

            TextBox_Id.Text = gvr.Cells[1].Text;
            CheckBox chk = gvr.Cells[2].Controls[0] as CheckBox;
            if (chk.Checked)
                DropDownList_Status.SelectedIndex = 0;
            else
                DropDownList_Status.SelectedIndex = 1;

            TextBox_FirstName.Text = gvr.Cells[3].Text;
            TextBox_LastName.Text = gvr.Cells[4].Text;
            TextBox_PersonalNumber.Text = gvr.Cells[5].Text;
            TextBox_PhoneNumber.Text = gvr.Cells[6].Text;
            TextBox_DateEmployed.Text = gvr.Cells[7].Text;
            TextBox_Specialization.Text = gvr.Cells[8].Text;
            TextBox_Department.Text = gvr.Cells[9].Text;
            TextBox_Email.Text = gvr.Cells[10].Text;
            TextBox_Password.Text = gvr.Cells[11].Text;
        }

        protected void Button_UpdateDoctor_Click(object sender, EventArgs e)
        {
            if (TextBox_Id.Text == "" || TextBox_FirstName.Text == "" || TextBox_LastName.Text == "" || TextBox_PersonalNumber.Text == "" ||
                TextBox_PhoneNumber.Text == "" || TextBox_Specialization.Text == "" || TextBox_Department.Text == "" ||
                TextBox_Email.Text == "" || TextBox_Password.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have to fill out all of the fields')", true);
            }
            else
            {
                Doctor doctor = new Doctor();
                doctor.Id = Convert.ToInt32(TextBox_Id.Text);
                doctor.FirstName = TextBox_FirstName.Text;
                doctor.LastName = TextBox_LastName.Text;
                doctor.PersonalNumber = TextBox_PersonalNumber.Text;
                doctor.PhoneNumber = TextBox_PhoneNumber.Text;
                doctor.Specialization = TextBox_Specialization.Text;
                doctor.Department = TextBox_Department.Text;
                doctor.DateEmployed = DateTime.Parse(TextBox_DateEmployed.Text);
                doctor.Email = TextBox_Email.Text;
                if (DropDownList_Status.SelectedItem.ToString() == "Active")
                    doctor.Status = true;
                else
                    doctor.Status = false;
                /*List<Doctor> temp = adminBusiness.GetAllDoctors().Where(doc => doc.Id == Convert.ToInt32(TextBox_Id.Text)).ToList();
                doctor.Password = temp[0].Password;*/
                doctor.Password = TextBox_Password.Text;
                string result = adminBusiness.UpdateDoctor(doctor);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + result + "')", true);
            }
        }

        protected void Button_InsertDoctor_Click(object sender, EventArgs e)
        {
            string url = "InsertDoctor.aspx";
            string s = "window.open('" + url + "', 'popup_window', 'width=1024,height=800,left=100,top=100,resizable=yes');";
            ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
        }
    }
}