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

            System.Data.DataTable dt = clsApplicationTypesBusinessLayer.GetApplicationTypeByID(_applicationTypeID);
            
            var result = clsFormDataService.PopulateDataFromTable(dt, row => {
                lblApplicationTypeID.Text = row["ApplicationTypeID"].ToString();
                txtTitle.Text = row["ApplicationTypeTitle"].ToString();
                txtFees.Text = row["ApplicationFees"].ToString();
            });
            
            if (!result.Success)
            {
                MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private bool IsDataValid()
        {
            bool isValid = true;
            decimal fees = 0;
            bool isFeesValid = decimal.TryParse(txtFees.Text, out fees);
            
            if (!clsApplicationTypesBusinessLayer.ValidateApplicationTypeTitle(txtTitle.Text))
            {
                errorProvider.SetError(txtTitle, "Title cannot be empty!");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtTitle, "");
            }

            if (string.IsNullOrWhiteSpace(txtFees.Text) || !isFeesValid)
            {
                errorProvider.SetError(txtFees, "Fees cannot be empty!");
                isValid = false;
            }
            else if (!clsApplicationTypesBusinessLayer.ValidateApplicationTypeFees(fees))
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

            string title = txtTitle.Text.Trim();
            decimal fees = decimal.Parse(txtFees.Text);
            
            var result = clsFormDataService.SaveData(
                (data) => clsApplicationTypesBusinessLayer.UpdateApplicationType(data._applicationTypeID, data.title, data.fees),
                (_applicationTypeID, title, fees)
            );
            
            if (result.Success)
            {
                MessageBox.Show("Application type updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            e.Handled = !clsFormDataService.IsNumericKey(e.KeyChar, true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveLogic(this, EventArgs.Empty);
        }
    }
}
