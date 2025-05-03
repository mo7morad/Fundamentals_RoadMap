using System;
using System.Data;
using System.Windows.Forms;
using BusinessLayer;
using Entities;
using Entities.Enums;


namespace DVLD
{
    public partial class ManageUsersForm : Form
    {
        private DataTable usersDataTable;
        private DataView usersDataView;     
        public ManageUsersForm()
        {
            InitializeComponent();
            LoadUsersData(this, EventArgs.Empty);
        }
 
        private void LoadUsersData(object sender, EventArgs e)
        {
            usersDataTable = clsUsersBusinessLayer.GetAllUsers();
            usersDataView = new DataView(usersDataTable);
            dataGridViewUsers.DataSource = usersDataView;
            lblRecordsCount.Text = $"# Records: {usersDataView.Count}";
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
            else if (selectedColumn == "Is Active" && comboBoxIsActive.SelectedItem != null)
            {
                string isActiveValue = comboBoxIsActive.SelectedItem.ToString();
                if(isActiveValue == "All")
                {
                    usersDataView.RowFilter = $"";
                }
                else if (isActiveValue == "Active")
                {
                    usersDataView.RowFilter = $"[{selectedColumn}] = true";
                }
                else
                {
                    usersDataView.RowFilter = $"[{selectedColumn}] = false";
                }
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
            Add_EditUserForm frm = new Add_EditUserForm();
            frm.OnSave += LoadUsersData;
            frm.ShowDialog(this);
        }

        private void ShowDetailsItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewUsers.SelectedCells[0].RowIndex;
            int userID = Convert.ToInt32(dataGridViewUsers.Rows[selectedRowIndex].Cells[0].Value);
            clsUser user = clsUsersBusinessLayer.GetUserByUserID(userID);
            if (user != null)
            {
                UserDetailsForm frm = new UserDetailsForm(user);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditUserItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewUsers.SelectedCells[0].RowIndex;
            int userID = Convert.ToInt32(dataGridViewUsers.Rows[selectedRowIndex].Cells[0].Value);
            clsUser user = clsUsersBusinessLayer.GetUserByUserID(userID);
            if (user != null)
            {
                Add_EditUserForm frm = new Add_EditUserForm(user, enFormMode.Update);
                frm.OnSave += LoadUsersData;
                frm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePasswordItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewUsers.SelectedCells[0].RowIndex;
            int userID = Convert.ToInt32(dataGridViewUsers.Rows[selectedRowIndex].Cells[0].Value);
            clsUser user = clsUsersBusinessLayer.GetUserByUserID(userID);
            ChangePasswordForm frm = new ChangePasswordForm(user);
            frm.ShowDialog();
            if (user != null)
            {
                //frm.SetUser(user);
                //frm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUserItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string deletionError = String.Empty;
                int selectedRowIndex = dataGridViewUsers.SelectedCells[0].RowIndex;
                int userID = Convert.ToInt32(dataGridViewUsers.Rows[selectedRowIndex].Cells[0].Value);

                if (clsUsersBusinessLayer.DeleteUser(userID, ref deletionError))
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsersData(sender, e);
                }
                else
                {
                    if (deletionError.Contains("REFERENCE constraint"))
                    {
                        MessageBox.Show("Cannot delete user. User is referenced in other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Error deleting user: {deletionError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Call functionality to be implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email functionality to be implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (comboBoxFilterBy.SelectedItem?.ToString() == "Is Active")
            {
                txtBoxFilterValue.Visible = false;
                comboBoxIsActive.Visible = true;
            }
            else
            {
                txtBoxFilterValue.Visible = true;
                comboBoxIsActive.Visible = false;
            }
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

        private void comboBoxIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter(sender, e);
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDetailsItem_Click(this, EventArgs.Empty);
        }
    }
}
