using BusinessLayer;
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
    public partial class AdminPanel : System.Web.UI.Page
    {
        private IAdminBusiness adminBusiness;
        private IDoctorBusiness doctorBusiness;
        public AdminPanel() { }

        public AdminPanel(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
        }
        public AdminPanel(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
        }

        public AdminPanel(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness)
        {
            adminBusiness = _adminBusiness;
            doctorBusiness = _doctorBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var admin = (Admin)Session["Admin"];
            TextBox_FirstName.Text = admin.FirstName;
            TextBox_LastName.Text = admin.LastName;
            TextBox_Email.Text = admin.Email;
            TextBox_PatientNumber.Text = doctorBusiness.GetAllPatients().Count().ToString();
            TextBox_DoctorNumber.Text = adminBusiness.GetAllDoctors().Count().ToString();
        }

        protected void Button_DoctorManagement_Click(object sender, EventArgs e)
        {
            string url = "DoctorManagement.aspx";
            string s = "window.open('" + url + "', 'popup_window', 'width=1280,height=800,left=100,top=100,resizable=yes');";
            ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);

        }
    }
}