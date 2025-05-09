using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ManageLocalDrivingLicenseApplicationForm: Form
    {
        private DataTable dtApplications;
        private DataView dvApplications;
        public ManageLocalDrivingLicenseApplicationForm()
        {
            InitializeComponent();
        }

        public void PopulateApplicationsDataGridView()
        {
            dtApplications = clsApplicationsBusinessLayer.GetAllApplications();
            dvApplications = new DataView(dtApplications);
            dataGridViewApplications.DataSource = dvApplications;
        }
    }
}
