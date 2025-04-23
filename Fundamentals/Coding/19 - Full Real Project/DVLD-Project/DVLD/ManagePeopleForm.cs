using System;
using System.Windows.Forms;
using BusinessLayer;
using DVLD_Entities.Enums;

namespace DVLD
{
    public partial class ManagePeopleForm : Form
    {
        public ManagePeopleForm()
        {
            InitializeComponent();
            LoadPeopleToDataGridView();
        }

        private void LoadPeopleToDataGridView()
        {
            dataGridViewPeople.DataSource = clsPeopleBusinessLayer.GetAllPeople();

            dataGridViewPeople.AutoResizeColumnHeadersHeight();
            if (dataGridViewPeople.Columns.Contains("Email"))
                dataGridViewPeople.Columns["Email"].MinimumWidth = 150;
            if (dataGridViewPeople.Columns.Contains("Image Path") && dataGridViewPeople.Columns.Contains("Address"))
            {
                dataGridViewPeople.Columns["Image Path"].Visible = false;
                dataGridViewPeople.Columns["Address"].Visible = false;
            }
        }
        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilterBy.Visible = comboBoxFilterBy.SelectedIndex != 0;
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
    }
}
