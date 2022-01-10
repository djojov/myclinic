using Shared.Interfaces;
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
    public partial class InsertDoctorForm : Form
    {
        private readonly IAdminBusiness adminBusiness;
        public InsertDoctorForm(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
            InitializeComponent();
        }

        private void InsertDoctorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
