using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using Entities;
using Entities.Enums;

namespace DVLD
{
    public partial class LocalDrivingLicenseApplicationForm : Form
    {
        public event EventHandler OnSave;
        private int _selectedPersonID = -1;
        private clsPerson _selectedPerson = null;
        private TabPage _currentTabPage;

        public LocalDrivingLicenseApplicationForm()
        {
            InitializeComponent();
            _currentTabPage = tabPagePersonalInfo;
            UpdateTabHeaderStyles();
            SetupTextChangeEvents();
            btnSave.Enabled = false;
        }

        private void SetupTextChangeEvents()
        {
            // Setup event handlers for validation
            txtApplicationFees.TextChanged += ApplicationInfo_TextChanged;
        }

        private void ApplicationInfo_TextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control == null) return;

            // Clear error when user starts typing
            errorProvider.SetError(control, "");
        }

        private void UpdateTabHeaderStyles()
        {
            linkLabelPersonalInfo.Font = (_currentTabPage == tabPagePersonalInfo)
                ? new Font(linkLabelPersonalInfo.Font, FontStyle.Bold)
                : new Font(linkLabelPersonalInfo.Font, FontStyle.Regular);

            linkLabelApplicationInfo.Font = (_currentTabPage == tabPageApplicationInfo)
                ? new Font(linkLabelApplicationInfo.Font, FontStyle.Bold)
                : new Font(linkLabelApplicationInfo.Font, FontStyle.Regular);
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            string findValue = txtFindValue.Text.Trim();
            if (string.IsNullOrEmpty(findValue))
            {
                MessageBox.Show("Please enter a value to search for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsPerson person = null;
            string findBy = comboBoxFindBy.Text;

            try
            {
                if (findBy == "Person ID" && int.TryParse(findValue, out int personID))
                {
                    person = clsPeopleBusinessLayer.GetPersonByID(personID);
                }
                else if (findBy == "National No")
                {
                    person = clsPeopleBusinessLayer.GetPersonByNationalNo(findValue);
                }

                if (person != null)
                {
                    DisplayPersonInfo(person);
                    _selectedPerson = person;
                    _selectedPersonID = person.PersonID;
                    btnNext.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Person not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPersonFields();
                    _selectedPerson = null;
                    _selectedPersonID = -1;
                    btnNext.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finding person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayPersonInfo(clsPerson person)
        {
            if (person == null) return;
            _selectedPersonID = person.PersonID;
            lblPersonID.Text = person.PersonID.ToString();
            lblPersonName.Text = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            lblNationalNo.Text = person.NationalNo;
            lblGender.Text = person.Gender ? "Female" : "Male";
            lblEmail.Text = person.Email ?? "[None]";
            lblAddress.Text = person.Address;
            lblDateOfBirth.Text = person.DateOfBirth.ToString("dd/MM/yyyy");
            lblPhone.Text = person.Phone;
            lblCountry.Text = person.Country?.CountryName ?? "[Unknown]";

            if (!string.IsNullOrEmpty(person.ImagePath) && System.IO.File.Exists(person.ImagePath))
            {
                try
                {
                    pictureBoxPerson.Image = Image.FromFile(person.ImagePath);
                }
                catch
                {
                    pictureBoxPerson.Image = person.Gender ? Properties.Resources.DefaultWoman : Properties.Resources.DefaultMan;
                }
            }
            else
            {
                pictureBoxPerson.Image = person.Gender ? Properties.Resources.DefaultWoman : Properties.Resources.DefaultMan;
            }
        }

        private void ClearPersonFields()
        {
            lblPersonID.Text = "[????]";
            lblPersonName.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblAddress.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblPhone.Text = "[????]";
            lblCountry.Text = "[????]";
            pictureBoxPerson.Image = Properties.Resources.DefaultMan;
        }

        private void linkLabelAddNewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_EditPersonForm frm = new Add_EditPersonForm(enFormMode.AddNew);
            frm.PersonSavedToDataBase += (s, args) =>
            {
                if (frm.PersonID > 0)
                {
                    _selectedPersonID = frm.PersonID;
                    _selectedPerson = clsPeopleBusinessLayer.GetPersonByID(_selectedPersonID);
                    DisplayPersonInfo(_selectedPerson);
                    btnNext.Enabled = true;
                }
            };
            frm.ShowDialog();
        }

        private void linkLabelEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_selectedPersonID <= 0)
            {
                MessageBox.Show("Please select a person first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Add_EditPersonForm frm = new Add_EditPersonForm(enFormMode.Update, _selectedPersonID);
            frm.PersonSavedToDataBase += (s, args) =>
            {
                // Refresh person data
                _selectedPerson = clsPeopleBusinessLayer.GetPersonByID(_selectedPersonID);
                DisplayPersonInfo(_selectedPerson);
            };
            frm.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentTabPage == tabPagePersonalInfo)
            {
                tabControl.SelectedTab = tabPageApplicationInfo;
                _currentTabPage = tabPageApplicationInfo;
                btnNext.Text = "Back";
                btnSave.Enabled = true;
                UpdateTabHeaderStyles();
                
                // Set default values for application info
                datePickerApplicationDate.Value = DateTime.Now;
                txtCreatedBy.Text = "Msaqer77"; // This could be the current user from the system
            }
            else
            {
                tabControl.SelectedTab = tabPagePersonalInfo;
                _currentTabPage = tabPagePersonalInfo;
                btnNext.Text = "Next";
                UpdateTabHeaderStyles();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedPersonID <= 0)
            {
                MessageBox.Show("Please select a person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateApplicationInputs())
            {
                MessageBox.Show("Please fix the validation errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Here you would save the license application data
            try
            {
                // Mock implementation - this would be replaced with actual saving logic
                MessageBox.Show("License application saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
                OnSave?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateApplicationInputs()
        {
            errorProvider.Clear();
            
            bool isFeesValid = ValidateApplicationFees();
            // Add more validations as needed
            
            return isFeesValid; // && other validations
        }

        private bool ValidateApplicationFees()
        {
            string fees = txtApplicationFees.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(fees))
            {
                errorProvider.SetError(txtApplicationFees, "Application fees are required.");
                return false;
            }
            
            if (!decimal.TryParse(fees, out decimal feeValue) || feeValue <= 0)
            {
                errorProvider.SetError(txtApplicationFees, "Application fees must be a positive number.");
                return false;
            }
            
            return true;
        }

        private void linkLabelPersonalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl.SelectedTab = tabPagePersonalInfo;
            _currentTabPage = tabPagePersonalInfo;
            btnNext.Text = "Next";
            UpdateTabHeaderStyles();
        }

        private void linkLabelApplicationInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_selectedPersonID <= 0)
            {
                MessageBox.Show("Please select a person first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tabControl.SelectedTab = tabPageApplicationInfo;
            _currentTabPage = tabPageApplicationInfo;
            btnNext.Text = "Back";
            btnSave.Enabled = true;
            UpdateTabHeaderStyles();
        }

        private void comboBoxFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFindValue.Clear();
        }

        private void txtFindValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if enter key is pressed, trigger the find button click
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnFindPerson_Click(sender, e);
            }
        }
    }
}
