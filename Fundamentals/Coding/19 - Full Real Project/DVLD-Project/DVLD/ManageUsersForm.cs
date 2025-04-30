using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using System.IO;

namespace DVLD
{
    public partial class ManageUsersForm : Form
    {
        private DataTable usersDataTable;
        private int recordsCount = 0;

        public ManageUsersForm()
        {
            InitializeComponent();
            LoadUsersData();
            PopulateFilterComboBox();
        }

        private void LoadUsersData()
        {
            // This would typically come from your data layer
            // For now, creating sample data
            usersDataTable = new DataTable();
            usersDataTable.Columns.Add("User ID", typeof(int));
            usersDataTable.Columns.Add("Person ID", typeof(int));
            usersDataTable.Columns.Add("Full Name", typeof(string));
            usersDataTable.Columns.Add("UserName", typeof(string));
            usersDataTable.Columns.Add("Is Active", typeof(bool));

            // Add sample data
            usersDataTable.Rows.Add(1, 1001, "Mohammed Saqer Mussa Abu-Hadhrout", "Master77", true);
            usersDataTable.Rows.Add(15, 1025, "Khalid ALi Maher Hamed", "user4", true);

            // Bind to grid
            dataGridViewUsers.DataSource = usersDataTable;

            // Update records count
            recordsCount = usersDataTable.Rows.Count;
            lblRecordsCount.Text = $"# Records: {recordsCount}";
        }

        private void PopulateFilterComboBox()
        {
            comboBoxFilterBy.Items.Clear();

            comboBoxFilterBy.Items.Add("User ID");
            comboBoxFilterBy.Items.Add("Person ID");
            comboBoxFilterBy.Items.Add("Full Name");
            comboBoxFilterBy.Items.Add("UserName");

            comboBoxFilterBy.SelectedIndex = 0;
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = comboBoxFilterBy.SelectedItem.ToString();
            string filterValue = txtBoxFilterValue.Text.Trim();

            if (string.IsNullOrEmpty(filterValue))
            {
                (usersDataTable.DefaultView).RowFilter = string.Empty;
            }
            else
            {
                // Apply filter based on selected column
                string filterExpression = $"[{filterColumn}] LIKE '%{filterValue}%'";
                (usersDataTable.DefaultView).RowFilter = filterExpression;
            }

            // Update records count
            lblRecordsCount.Text = $"# Records: {usersDataTable.DefaultView.Count}";
        }

        private void UsersGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridViewUsers.ClearSelection();
                dataGridViewUsers.Rows[e.RowIndex].Selected = true;

                // Show context menu at cursor position
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New User functionality to be implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowDetailsItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show User Details functionality to be implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUserItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit User functionality to be implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangePasswordItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Password functionality to be implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteUserItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("User deletion functionality to be implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxFilterValue_TextChanged(object sender, EventArgs e)
        {
            FilterTextBox_TextChanged(sender, e);
        }
    }
}
