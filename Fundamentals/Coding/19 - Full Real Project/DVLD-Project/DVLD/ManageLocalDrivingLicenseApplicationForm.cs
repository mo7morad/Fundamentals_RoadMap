using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using Entities.Enums;


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

        private void ManageLocalDrivingLicenseApplicationForm_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            PopulateApplicationsDataGridView();
            CenterTitleElements();
        }

        private void StyleDataGridView()
        {
            // Style the DataGridView for better appearance
            dataGridViewApplications.BorderStyle = BorderStyle.None;
            dataGridViewApplications.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewApplications.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewApplications.DefaultCellStyle.SelectionBackColor = Color.FromArgb(208, 179, 179);
            dataGridViewApplications.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewApplications.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewApplications.EnableHeadersVisualStyles = false;
            dataGridViewApplications.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewApplications.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(180, 0, 0);
            dataGridViewApplications.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewApplications.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dataGridViewApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewApplications.ColumnHeadersHeight = 35;
            dataGridViewApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Center text in all cells
            dataGridViewApplications.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Center text in column headers
            dataGridViewApplications.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Center text in all cells
            dataGridViewApplications.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Center text in column headers
            dataGridViewApplications.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        
        private void CenterTitleElements()
        {
            pictureBoxLocalLicense.Left = (panelMainTitle.Width - pictureBoxLocalLicense.Width) / 2;
            lblManageLocalLicense.Left = (panelMainTitle.Width - lblManageLocalLicense.Width) / 2;
        }
        
        private void ManageLocalDrivingLicenseApplicationForm_Resize(object sender, EventArgs e)
        {
            // Recenter title elements when form is resized
            CenterTitleElements();

            // Adjust padding based on form width for better appearance
            if (this.Width > 1000)
            {
                panelDataGridView.Padding = new Padding(20);
            }
            else
            {
                panelDataGridView.Padding = new Padding(10);
            }
        }
        
        private enAppStatus GetAppStatusFromInt(int statusCode)
        {
            return (enAppStatus)statusCode;
        }

        public void PopulateApplicationsDataGridView()
        {
            dtApplications = clsApplicationsBusinessLayer.GetAllApplications();
            dvApplications = new DataView(dtApplications);
            dataGridViewApplications.DataSource = dvApplications;
            lblRecords.Text += dtApplications.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
