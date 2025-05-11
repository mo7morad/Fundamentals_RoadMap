using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using Entities.Enums;

namespace DVLD
{
    public partial class ManageLocalDrivingLicenseApplicationForm : Form
    {
        private DataTable dtApplications;
        private DataView dvApplications;
        private readonly string[] filterCriteria = { "None", "D.L App ID", "National No", "Full Name", "Status" };

        public ManageLocalDrivingLicenseApplicationForm()
        {
            InitializeComponent();
        }

        private void ManageLocalDrivingLicenseApplicationForm_Load(object sender, EventArgs e)
        {
            SetupFilterControls();
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

            // Center text in all cells and headers
            dataGridViewApplications.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            panelDataGridView.Padding = this.Width > 1000 ? new Padding(20) : new Padding(10);
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
            UpdateRecordsCount();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupFilterControls()
        {
            // Initialize and populate the filter criteria combobox
            cmbFilterBy.Items.AddRange(filterCriteria);
            cmbFilterBy.SelectedIndex = 0; // Default to "None"

            // Initialize the status filter combobox
            cmbStatus.Items.AddRange(Enum.GetNames(typeof(enAppStatus)));
            cmbStatus.Visible = false;

            // Setup filter textbox
            txtFilter.Visible = false;

            // Handle filter combobox change
            cmbFilterBy.SelectedIndexChanged += CmbFilterBy_SelectedIndexChanged;

            // Handle filter textbox and status combobox change events
            txtFilter.TextChanged += ApplyFilter;
            cmbStatus.SelectedIndexChanged += ApplyFilter;
        }

        private void CmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show/hide controls based on filter selection
            string selectedFilter = cmbFilterBy.SelectedItem.ToString();

            if (selectedFilter == "None")
            {
                txtFilter.Visible = false;
                cmbStatus.Visible = false;
                // Reset filter
                if (dvApplications != null)
                {
                    dvApplications.RowFilter = string.Empty;
                    UpdateRecordsCount();
                }
            }
            else if (selectedFilter == "Status")
            {
                txtFilter.Visible = false;
                cmbStatus.Visible = true;
                cmbStatus.SelectedIndex = -1; // Reset selection
            }
            else
            {
                txtFilter.Visible = true;
                cmbStatus.Visible = false;
                txtFilter.Clear();
                txtFilter.Focus();
            }
        }

        private void ApplyFilter(object sender, EventArgs e)
        {
            if (dvApplications == null) return;

            string selectedFilter = cmbFilterBy.SelectedItem.ToString();
            string filterValue = string.Empty;
            string filterColumn = string.Empty;

            switch (selectedFilter)
            {
                case "D.L App ID":
                    filterColumn = "D.L Application ID";
                    filterValue = txtFilter.Text.Trim();
                    if (filterValue != string.Empty && int.TryParse(filterValue, out _))
                        dvApplications.RowFilter = $"[{filterColumn}] = {filterValue}";
                    else
                        dvApplications.RowFilter = string.Empty;
                    break;

                case "National No":
                    filterColumn = "National Number";
                    filterValue = txtFilter.Text.Trim();
                    if (filterValue != string.Empty)
                        dvApplications.RowFilter = $"[{filterColumn}] LIKE '%{filterValue}%'";
                    else
                        dvApplications.RowFilter = string.Empty;
                    break;

                case "Full Name":
                    filterColumn = "Full Name";
                    filterValue = txtFilter.Text.Trim();
                    if (filterValue != string.Empty)
                        dvApplications.RowFilter = $"[{filterColumn}] LIKE '%{filterValue}%'";
                    else
                        dvApplications.RowFilter = string.Empty;
                    break;

                case "Status":
                    if (cmbStatus.SelectedIndex >= 0)
                    {
                        string statusName = cmbStatus.SelectedItem.ToString();
                        // Parse enum value from name
                        if (Enum.TryParse(statusName, out enAppStatus status))
                        {
                            int statusCode = (int)status;
                            dvApplications.RowFilter = $"StatusID = {statusCode}";
                        }
                    }
                    else
                    {
                        dvApplications.RowFilter = string.Empty;
                    }
                    break;
            }

            UpdateRecordsCount();
        }

        private void UpdateRecordsCount()
        {
            lblRecords.Text = $"# Records: {dvApplications.Count}";
        }

        private void pictureBoxAddNewApp_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplicationForm frm = new LocalDrivingLicenseApplicationForm();
            frm.FormClosed += (s, args) => PopulateApplicationsDataGridView();
            frm.Show();
        }
    }
}
