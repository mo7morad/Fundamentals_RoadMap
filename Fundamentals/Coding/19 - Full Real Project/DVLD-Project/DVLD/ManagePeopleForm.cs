using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using BusinessLayer;
using DVLD_Entities.Enums;

namespace DVLD
{
    public partial class ManagePeopleForm : Form
    {
        private DataTable peopleDataTable;
        private DataView peopleDataView;
        
        public ManagePeopleForm()
        {
            InitializeComponent();
            this.Load += MainPeopleForm_Load;
        }
        
        private void MainPeopleForm_Load(object sender, EventArgs e)
        {
            LoadPeopleToDataGridView();
            PopulateComboBoxFilterBy();
        }

        private void LoadPeopleToDataGridView()
        {
            peopleDataTable = clsPeopleBusinessLayer.GetAllPeople();
            peopleDataView = new DataView(peopleDataTable);
            if (peopleDataTable == null || peopleDataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                dataGridViewPeople.DataSource = peopleDataView;

                dataGridViewPeople.AutoResizeColumnHeadersHeight();
                if (dataGridViewPeople.Columns.Contains("Email"))
                    dataGridViewPeople.Columns["Email"].MinimumWidth = 150;

                if (dataGridViewPeople.Columns.Contains("Image Path") && dataGridViewPeople.Columns.Contains("Address"))
                {
                    dataGridViewPeople.Columns["Image Path"].Visible = false;
                    dataGridViewPeople.Columns["Address"].Visible = false;
                }
            }
            lblRecordsCount.Text = $"# Records: {peopleDataView.Count}";
        }

        private void PopulateComboBoxFilterBy()
        {
            comboBoxFilterBy.Items.Clear();
            comboBoxFilterBy.Items.Add("None");

            foreach (DataGridViewColumn column in dataGridViewPeople.Columns)
            {
                if (!column.Visible || column.HeaderText == "Date Of Birth")
                    continue;

                comboBoxFilterBy.Items.Add(column.HeaderText);
            }
            comboBoxFilterBy.SelectedIndex = 0;
        }

        private void ApplyFilter()
        {
            string selectedColumn = comboBoxFilterBy.SelectedItem?.ToString();
            string filterText = txtBoxFilterBy.Text.Trim();
            filterText = filterText.Replace("'", "''"); // Prevent SQL injection in the RowFilter
            if (string.IsNullOrWhiteSpace(filterText))
                peopleDataView.RowFilter = "";
            if (!string.IsNullOrEmpty(filterText) && selectedColumn != "None")
            {
                if (selectedColumn == "Gender")
                {
                    // Handle gender filtering (case-insensitive)
                    if (filterText.IndexOf("m", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        peopleDataView.RowFilter = "[Gender] = 'Male'";
                    }
                    else if (filterText.IndexOf("f", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        peopleDataView.RowFilter = "[Gender] = 'Female'";
                    }
                    else
                    {
                        peopleDataView.RowFilter = ""; // Clear if input doesn't match M/m/F/f
                    }
                }
         
                else
                {
                    // Standard filtering for other columns
                    peopleDataView.RowFilter = $"[{selectedColumn}] LIKE '%{filterText}%'";
                }
            }
            else
            {
                peopleDataView.RowFilter = ""; // Clear filter
            }
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilterBy.Visible = comboBoxFilterBy.SelectedIndex != 0;
            txtBoxFilterBy.Clear();
        }

        private void CreateAddNewPersonForm()
        {
            Add_EditPersonForm addNewForm = new Add_EditPersonForm(enFormMode.AddNew, -1);
            addNewForm.PersonSavedToDataBase += RefreshPeopleList_OnSave;
            addNewForm.ShowDialog();
        }
        
        private void CreateUpdatePersonForm(int personID)
        {
            Add_EditPersonForm editForm = new Add_EditPersonForm(enFormMode.Update, personID);
            editForm.PersonSavedToDataBase += RefreshPeopleList_OnSave;
            editForm.ShowDialog();
        }
        
        private void CreatePersonInfoCard(int personID)
        {
            PersonDetailsForm personInfoForm = new PersonDetailsForm(personID);
            personInfoForm.OnClose += (s, e) => LoadPeopleToDataGridView();
            personInfoForm.ShowDialog();
        }
        
        private void pictureBoxAddPerson_Click(object sender, EventArgs e)
        {
            CreateAddNewPersonForm();
        }
        
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAddNewPersonForm();
        }
        
        private void pictureBoxAddPerson_MouseEnter(object sender, EventArgs e)
        {
            toolTipAddNewPerson.SetToolTip(pictureBoxAddPerson, "Add a new person");
        }
        
        private void dataGridViewPeople_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridViewPeople.ClearSelection();
                dataGridViewPeople.Rows[e.RowIndex].Selected = true;
                contextMenuStripDataGridView.Show(Cursor.Position);
            }
        }
        
        private void btnClosePeopleForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void RefreshPeopleList_OnSave(object sender, EventArgs e)
        {
            LoadPeopleToDataGridView();
        }
        
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string error = string.Empty;

                // Get the image path for deletion
                int selectedRowIndex = dataGridViewPeople.SelectedCells[0].RowIndex;
                int personId = Convert.ToInt32(dataGridViewPeople.Rows[selectedRowIndex].Cells[0].Value);
                string photoPath = dataGridViewPeople.Rows[selectedRowIndex].Cells["Image Path"].Value?.ToString();


                bool isDeleted = clsPeopleBusinessLayer.DeletePerson(personId, ref error);
                if (isDeleted)
                {
                    // Try to delete the photo from the device
                    if (!string.IsNullOrWhiteSpace(photoPath) && System.IO.File.Exists(photoPath))
                    {
                        try
                        {
                            System.IO.File.Delete(photoPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Photo could not be deleted: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    MessageBox.Show("Person deleted successfully.");
                    LoadPeopleToDataGridView();
                }
                else
                {
                    if (error.Contains("REFERENCE constraint"))
                    {
                        MessageBox.Show("Cannot delete this person. They are linked to existing applications.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewPeople.SelectedCells[0].RowIndex;
            int personId = Convert.ToInt32(dataGridViewPeople.Rows[selectedRowIndex].Cells[0].Value);
            CreateUpdatePersonForm(personId);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridViewPeople.SelectedCells[0].RowIndex;
            int personID = Convert.ToInt32(dataGridViewPeople.Rows[selectedRowIndex].Cells[0].Value);
            CreatePersonInfoCard(personID);
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Be Implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Be Implemented", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBoxFilterBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void txtBoxFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedItem = comboBoxFilterBy.SelectedItem?.ToString();

            if (selectedItem == null)
                return;

            if (selectedItem == "Person ID" || selectedItem == "Phone")
            {
                // Allow only digits for Person ID and Phone filtering
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));
            }
            else if (selectedItem.Contains("Name") || selectedItem == "Gender" || selectedItem == "Country")
            {
                // Allow only letters and spaces for Name, gender, and country filtering
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ');
            }
            else
            {
                // Allow all characters for other columns
                e.Handled = false;
            }
        }

        private void dataGridViewPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dataGridViewPeople.SelectedCells[0].RowIndex;
            int personID = Convert.ToInt32(dataGridViewPeople.Rows[selectedRowIndex].Cells[0].Value);
            CreatePersonInfoCard(personID);
        }
    }
}
