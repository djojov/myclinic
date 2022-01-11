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
    public partial class InsertPatientForm : Form
    {
        IDoctorBusiness doctorBusiness;
        public InsertPatientForm(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
            InitializeComponent();
        }
        public PatientManagementForm RefPatientManagementForm { get; set; }
        private void InsertPatientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
