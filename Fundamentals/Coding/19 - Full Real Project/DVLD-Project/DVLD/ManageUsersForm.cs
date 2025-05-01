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
        private DataView usersDataView;     
        public ManageUsersForm()
        {
            InitializeComponent();
            LoadUsersData();
            PopulateFilterComboBox();
        }

        private void LoadUsersData()
        {
            usersDataTable = clsUsersBusinessLayer.GetAllUsers();
            usersDataView = new DataView(usersDataTable);
            dataGridViewUsers.DataSource = usersDataView;
            lblRecordsCount.Text = $"# Records: {usersDataView.Count}";
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

        private void ApplyFilter(object sender, EventArgs e)
        {
            string selectedColumn = comboBoxFilterBy.SelectedItem?.ToString();
            string filterText = txtBoxFilterValue.Text.Trim();
            filterText = filterText.Replace("'", "''"); // Prevent SQL injection in the RowFilter

            if (string.IsNullOrEmpty(filterText))
            {
                usersDataView.RowFilter = "";
            }
            if (selectedColumn == "User ID" || selectedColumn == "Person ID")
            {
                if (int.TryParse(filterText, out int filterValue))
                {
                    usersDataView.RowFilter = $"[{selectedColumn}] = {filterValue}";
                }
            }
            else if (selectedColumn == "Is Active")
            {
                usersDataView.RowFilter = $"[{selectedColumn}] = '{filterText}'";
            }
            else
            {
                usersDataView.RowFilter = $"[{selectedColumn}] LIKE '%{filterText}%'";
            }

            // Update the label with the number of records after filtering
            lblRecordsCount.Text = $"# Records: {usersDataView.Count}";
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
            AddNewUserForm frm = new AddNewUserForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadUsersData();  // Refresh the users list
            }
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
            ApplyFilter(sender, e);
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilterValue.Text = string.Empty;
        }

        private void txtBoxFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedItem = comboBoxFilterBy.SelectedItem?.ToString();

            if (selectedItem == null)
                return;

            if (selectedItem == "Person ID" || selectedItem == "User ID")
            {
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
            }
            else
            {
                // Allow all characters for other filters
                e.Handled = false;
            }
        }
    }
}
