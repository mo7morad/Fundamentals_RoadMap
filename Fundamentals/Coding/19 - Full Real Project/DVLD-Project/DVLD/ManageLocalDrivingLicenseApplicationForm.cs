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

        private void dataGridViewApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // Select the row that was right-clicked
                dataGridViewApplications.ClearSelection();
                dataGridViewApplications.Rows[e.RowIndex].Selected = true;
                dataGridViewApplications.CurrentCell = dataGridViewApplications.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];

                // Update menu items based on application status before showing context menu
                //UpdateContextMenuItems();
            }
        }

        //private void UpdateContextMenuItems()
        //{
        //    // If no row is selected, disable all menu items
        //    if (dataGridViewApplications.SelectedRows.Count == 0)
        //    {
        //        foreach (ToolStripItem item in contextMenuStripApp.Items)
        //        {
        //            item.Enabled = false;
        //        }
        //        return;
        //    }

        //    // Get the status of the selected application
        //    int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
        //    int statusID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["StatusID"].Value);
        //    enAppStatus appStatus = GetAppStatusFromInt(statusID);

        //    // Enable/disable menu items based on application status
        //    showApplicationDetailsToolStripMenuItem.Enabled = true; // Always enabled
        //    showPersonLicenseHistoryToolStripMenuItem.Enabled = true; // Always enabled

        //    // Can only edit or delete if status is NEW
        //    editApplicationToolStripMenuItem.Enabled = (appStatus == enAppStatus.New);
        //    deleteApplicationToolStripMenuItem.Enabled = (appStatus == enAppStatus.New);

        //    // Can only cancel if status is not CANCELED
        //    cancelApplicationToolStripMenuItem.Enabled = (appStatus != enAppStatus.Canceled);

        //    // Schedule tests enabled based on application status
        //    bool canScheduleTests = (appStatus == enAppStatus.New ||
        //                           appStatus == enAppStatus.Canceled ||
        //                           appStatus == enAppStatus.Rejected);
        //    scheduleTestsToolStripMenuItem.Enabled = canScheduleTests;
        //    scheduleVisionTestToolStripMenuItem.Enabled = canScheduleTests;
        //    scheduleWrittenTestToolStripMenuItem.Enabled = canScheduleTests;
        //    scheduleStreetTestToolStripMenuItem.Enabled = canScheduleTests;

        //    // Issue license only if tests are passed
        //    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (appStatus == enAppStatus.PassedAllTests);

        //    // Show license only if it's been issued
        //    showLicenseToolStripMenuItem.Enabled = (appStatus == enAppStatus.LicenseIssued);
        //}

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0) return;

            int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
            int applicationID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["D.L Application ID"].Value);

            // Add your code to show application details
            MessageBox.Show($"Showing details for Application ID: {applicationID}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0) return;

            int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
            int applicationID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["D.L Application ID"].Value);

            // Add your code to edit application
            MessageBox.Show($"Editing Application ID: {applicationID}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0) return;

            int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
            int applicationID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["D.L Application ID"].Value);

            DialogResult result = MessageBox.Show($"Are you sure you want to delete Application ID: {applicationID}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Add your code to delete application
                MessageBox.Show($"Application ID: {applicationID} deleted successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the data grid
                PopulateApplicationsDataGridView();
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0) return;

            int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
            int applicationID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["D.L Application ID"].Value);

            DialogResult result = MessageBox.Show($"Are you sure you want to cancel Application ID: {applicationID}?",
                "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Add your code to cancel application
                MessageBox.Show($"Application ID: {applicationID} canceled successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the data grid
                PopulateApplicationsDataGridView();
            }
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0) return;

            int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
            int applicationID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["D.L Application ID"].Value);

            // Add your code to schedule vision test
            MessageBox.Show($"Scheduling Vision Test for Application ID: {applicationID}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0) return;

            int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
            int applicationID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["D.L Application ID"].Value);

            // Add your code to schedule written test
            MessageBox.Show($"Scheduling Written Test for Application ID: {applicationID}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0) return;

            int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
            int applicationID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["D.L Application ID"].Value);

            // Add your code to schedule street test
            MessageBox.Show($"Scheduling Street Test for Application ID: {applicationID}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0) return;

            int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
            int applicationID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["D.L Application ID"].Value);

            // Add your code to issue driving license
            MessageBox.Show($"Issuing Driving License for Application ID: {applicationID}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0) return;

            int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
            int applicationID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["D.L Application ID"].Value);

            // Add your code to show license
            MessageBox.Show($"Showing License for Application ID: {applicationID}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0) return;

            int selectedRowIndex = dataGridViewApplications.SelectedCells[0].RowIndex;
            int personID = Convert.ToInt32(dataGridViewApplications.Rows[selectedRowIndex].Cells["Person ID"].Value);

            // Add your code to show person license history
            MessageBox.Show($"Showing License History for Person ID: {personID}", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
