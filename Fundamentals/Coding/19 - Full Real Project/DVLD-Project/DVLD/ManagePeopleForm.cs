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
using static DVLD.addNewPersonForm;

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

        private void pictureBoxAddPerson_Click(object sender, EventArgs e)
        {
            addNewPersonForm addNewForm = new addNewPersonForm();
            addNewForm.PersonAddedToDatabase += RefreshPeopleList_OnSave;
            addNewForm.ShowDialog();
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
    }
}
