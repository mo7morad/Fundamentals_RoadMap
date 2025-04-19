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
        public partial class PeopleForm : Form
        {
            public PeopleForm()
            {
                InitializeComponent();
                comboBoxFilterBy.SelectedIndex = 0;
                LoadPeople();
        }

        private void LoadPeople()
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
                if (addNewForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPeople(); // Refresh the list after adding
                }
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
    }
}
