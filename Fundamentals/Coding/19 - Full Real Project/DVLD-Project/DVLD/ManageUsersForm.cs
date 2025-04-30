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
            usersDataTable = clsUsersBusinessLayer.GetAllUsers();
            DataView usersDataView = new DataView(usersDataTable);
            dataGridViewUsers.DataSource = usersDataView;
        }

        private void PopulateFilterComboBox()
        {
            comboBoxFilterBy.Items.Clear();

            comboBoxFilterBy.Items.Add("User ID");
            comboBoxFilterBy.Items.Add("Person ID");
            comboBoxFilterBy.Items.Add("Full Name");
            comboBoxFilterBy.Items.Add("User Name");
            comboBoxFilterBy.Items.Add("Is Active");

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
