using BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UpdateTestTypeForm : Form
    {
        private int _testTypeId = -1;

        public UpdateTestTypeForm(int testTypeId)
        {
            _testTypeId = testTypeId;
            InitializeComponent();
            LoadTestTypeInfo();
        }

        private void LoadTestTypeInfo()
        {
            if (_testTypeId <= 0)
            {
                MessageBox.Show("No test type selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            System.Data.DataTable dt = clsTestTypesBusinessLayer.GetTestTypeByID(_testTypeId);
            
            var result = clsFormDataService.PopulateDataFromTable(dt, row => {
                lblApplicationTypeID.Text = row["ID"].ToString();
                txtTitle.Text = row["Title"].ToString();
                txtDescription.Text = row["Description"].ToString();
                txtFees.Text = row["Fees"].ToString();
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

            if (!clsTestTypesBusinessLayer.ValidateTestTypeTitle(txtTitle.Text))
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
            else if (!clsTestTypesBusinessLayer.ValidateTestTypeFees(fees))
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
            string description = txtDescription.Text.Trim();
            decimal fees = decimal.Parse(txtFees.Text);
            
            var result = clsFormDataService.SaveData(
                (data) => clsTestTypesBusinessLayer.UpdateTestType(data._testTypeId, data.title, data.description, data.fees),
                (_testTypeId, title, description, fees)
            );
            
            if (result.Success)
            {
                MessageBox.Show("Test type updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
