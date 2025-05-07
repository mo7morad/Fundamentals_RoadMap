using BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UpdateApplicationTypeForm : Form
    {
        private int _applicationTypeID = -1;

        public UpdateApplicationTypeForm(int applicationTypeID)
        {
            _applicationTypeID = applicationTypeID;
            InitializeComponent();
            LoadApplicationTypeInfo();
        }

        private void LoadApplicationTypeInfo()
        {
            if (_applicationTypeID <= 0)
            {
                MessageBox.Show("No application type selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                System.Data.DataTable dt = clsApplicationTypesBusinessLayer.GetApplicationTypeByID(_applicationTypeID);

                if (dt != null && dt.Rows.Count > 0)
                {
                    lblApplicationTypeID.Text = dt.Rows[0]["ApplicationTypeID"].ToString();
                    txtTitle.Text = dt.Rows[0]["ApplicationTypeTitle"].ToString();
                    txtFees.Text = dt.Rows[0]["ApplicationFees"].ToString();
                }
                else
                {
                    MessageBox.Show("Application type not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application type: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private bool IsDataValid()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider.SetError(txtTitle, "Title cannot be empty!");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtTitle, "");
            }

            if (string.IsNullOrWhiteSpace(txtFees.Text))
            {
                errorProvider.SetError(txtFees, "Fees cannot be empty!");
                isValid = false;
            }
            else if (!decimal.TryParse(txtFees.Text, out decimal fee) || fee < 0)
            {
                errorProvider.SetError(txtFees, "Fees must be a valid positive number!");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtFees, "");
            }

            return isValid;
        }

        private void SaveLogic(object sender, EventArgs e)
        {
            if (!IsDataValid())
                return;

            try
            {
                string title = txtTitle.Text.Trim();
                decimal fees = decimal.Parse(txtFees.Text);
                string errorMsg = string.Empty;

                bool updateResult = clsApplicationTypesBusinessLayer.UpdateApplicationType(_applicationTypeID, title, fees);

                if (updateResult)
                {
                    MessageBox.Show("Application type updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Failed to update application type: {errorMsg}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating application type: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtTitle, "");
        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtFees, "");
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, decimal point and control characters
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveLogic(this, EventArgs.Empty);
        }
    }
}
