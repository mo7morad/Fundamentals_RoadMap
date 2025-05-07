using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ManageApplicationTypesForm: Form
    {
        private DataTable dtApplicationTypes = null;
        private DataView dvApplicationTypes = null;
        
        public ManageApplicationTypesForm()
        {
            InitializeComponent();
            LoadDataGridView();
            PopulateRecordsCount();
        }

        private void LoadDataGridView()
        {
            try
            {
                dtApplicationTypes = clsApplicationTypesBusinessLayer.GetApplicationTypes();
                
                if (dtApplicationTypes == null || dtApplicationTypes.Rows.Count == 0)
                {
                    MessageBox.Show("No application types found.", "Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                dvApplicationTypes = new DataView(dtApplicationTypes);
                dataGridViewApplicationTypes.DataSource = dvApplicationTypes;

                // Fees formatting
                dataGridViewApplicationTypes.Columns["ApplicationFees"].DefaultCellStyle.Format = "N1";

                // Centering the columns text
                foreach (DataGridViewColumn column in dataGridViewApplicationTypes.Columns)
                {
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application types: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void PopulateRecordsCount()
        {
            lblRecords.Text = "# Records: " + (dvApplicationTypes?.Count ?? 0);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplicationTypes.CurrentRow != null)
            {
                int applicationTypeId = Convert.ToInt32(dataGridViewApplicationTypes.CurrentRow.Cells["ApplicationTypeId"].Value);
                UpdateApplicationTypeForm updateApplicationTypeForm = new UpdateApplicationTypeForm(applicationTypeId);
                updateApplicationTypeForm.FormClosed += (s, args) => LoadDataGridView();
                updateApplicationTypeForm.ShowDialog();
            }   
            else
            {
                MessageBox.Show("Please select an application type to edit.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewApplicationTypes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Select the row that was right-clicked
                if (e.RowIndex >= 0)
                {
                    // Clear current selection first
                    dataGridViewApplicationTypes.ClearSelection();

                    // Select the row under the cursor
                    dataGridViewApplicationTypes.Rows[e.RowIndex].Selected = true;
                    dataGridViewApplicationTypes.CurrentCell = dataGridViewApplicationTypes.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];

                    // Show the context menu at cursor position
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

    }
}
