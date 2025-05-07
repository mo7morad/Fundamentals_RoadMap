using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ManageTestTypesForm : Form
    {
        private DataTable dtApplicationTypes = null;
        private DataView dvApplicationTypes = null;

        public ManageTestTypesForm()
        {
            InitializeComponent();
            LoadDataGridView();
            PopulateRecordsCount();
        }

        private void LoadDataGridView()
        {
            try
            {
                dtApplicationTypes = clsTestTypesBusinessLayer.GetAllTestTypes();

                if (dtApplicationTypes == null || dtApplicationTypes.Rows.Count == 0)
                {
                    MessageBox.Show("No test types found.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dvApplicationTypes = new DataView(dtApplicationTypes);
                dataGridViewTestTypes.DataSource = dvApplicationTypes;

                // Fees formatting
                dataGridViewTestTypes.Columns["Fees"].DefaultCellStyle.Format = "N1";

                // Centering the columns text
                foreach (DataGridViewColumn column in dataGridViewTestTypes.Columns)
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
            if (dataGridViewTestTypes.CurrentRow != null)
            {
                int testTypeId = Convert.ToInt32(dataGridViewTestTypes.CurrentRow.Cells["ID"].Value);
                UpdateTestTypeForm updateApplicationTypeForm = new UpdateTestTypeForm(testTypeId);
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
                    dataGridViewTestTypes.ClearSelection();

                    // Select the row under the cursor
                    dataGridViewTestTypes.Rows[e.RowIndex].Selected = true;
                    dataGridViewTestTypes.CurrentCell = dataGridViewTestTypes.Rows[e.RowIndex].Cells[e.ColumnIndex >= 0 ? e.ColumnIndex : 0];

                    // Show the context menu at cursor position
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
