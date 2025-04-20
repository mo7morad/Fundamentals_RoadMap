using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

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
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxFilterBy.Visible = comboBoxFilterBy.SelectedIndex != 0;

            // You can add logic like:
            // ApplyFilter(comboBoxFilterBy.SelectedItem.ToString(), txtBoxFilterBy.Text);
        }

        private void OpenAddNewPersonForm()
        {
            addNewPersonForm addNewForm = new addNewPersonForm();
            addNewForm.PersonAddedToDatabase += RefreshPeopleList_OnSave;
            addNewForm.ShowDialog();
        }
        private void pictureBoxAddPerson_Click(object sender, EventArgs e)
        {
            OpenAddNewPersonForm();
        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddNewPersonForm();
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
                int selectedRowIndex = dataGridViewPeople.SelectedCells[0].RowIndex;
                int personId = Convert.ToInt32(dataGridViewPeople.Rows[selectedRowIndex].Cells[0].Value);

                string error = string.Empty;
                bool isDeleted = clsPeopleBusinessLayer.DeletePerson(personId, ref error);

                if (isDeleted)
                {
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

        }
    }
}
