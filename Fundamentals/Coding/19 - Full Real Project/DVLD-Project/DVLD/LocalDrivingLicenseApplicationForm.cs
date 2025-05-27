using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using Entities;
using Entities.Enums;

namespace DVLD
{
    public partial class LocalDrivingLicenseApplicationForm : Form
    {
        private DataTable dtLicenseClasses;
        private DataView dvLicenseClasses;
        private int _selectedPersonID = -1;
        private clsPerson _selectedPerson = null;
        private TabPage _currentTabPage;

        public LocalDrivingLicenseApplicationForm()
        {
            InitializeComponent();
        }

        private void LocalDrivingLicenseApplicationForm_Load(object sender, EventArgs e)
        {
            // Initialize the form with default values
            _currentTabPage = tabPagePersonalInfo;
            btnNext.Enabled = false;
            btnSave.Enabled = false;
            
            // Set application date to today
            datePickerApplicationDate.Value = DateTime.Now;
            
            // Get application fees from database
            decimal applicationFees = clsApplicationTypesBusinessLayer.GetApplicationFeesByID(1);
            txtApplicationFees.Text = applicationFees.ToString("N2") + "$";
            
            // Populate License Classes Combo Box
            LoadLicenseClasses();
        }

        private void LoadLicenseClasses()
        {
            // Populate License Classes Combo Box
            dtLicenseClasses = clsLicensesBusinessLayer.GetAllLicenseClasses();
            
            if (dtLicenseClasses != null && dtLicenseClasses.Rows.Count > 0)
            {
                dvLicenseClasses = new DataView(dtLicenseClasses);
                comboBoxLicenseClass.DataSource = dvLicenseClasses;
                comboBoxLicenseClass.DisplayMember = "ClassName";
                comboBoxLicenseClass.ValueMember = "LicenseClassID";
                comboBoxLicenseClass.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Failed to load license classes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnFindPerson_Click(sender, e);
            }
        }
        
        private bool IsApplicationDataValid()
        {
            errorProvider.Clear();
            bool isValid = true;
            
            // Check if a license class is selected
            if (comboBoxLicenseClass.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxLicenseClass, "Please select a license class.");
                isValid = false;
            }
            
            // Make sure fees are valid
            string feeText = txtApplicationFees.Text.Replace("$", "").Trim();
            if (!decimal.TryParse(feeText, out decimal fees) || fees <= 0)
            {
                errorProvider.SetError(txtApplicationFees, "Application fees must be a valid positive number.");
                isValid = false;
            }
            
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedPersonID <= 0)
            {
                MessageBox.Show("Please select a person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (!IsApplicationDataValid())
            {
                MessageBox.Show("Please fix validation errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get the selected license class ID
                if (!(comboBoxLicenseClass.SelectedValue is int licenseClassID))
                {
                    MessageBox.Show("Invalid license class selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Check if person is eligible for this license
                if (!clsApplicationsBusinessLayer.IsPersonEligibleForLicense(_selectedPersonID, licenseClassID))
                {
                    // Check what the current status is to show a more specific message
                    enAppStatus status = clsApplicationsBusinessLayer.GetApplicationStatus(_selectedPersonID, licenseClassID);
                    
                    if (status == enAppStatus.New)
                    {
                        MessageBox.Show("This person already has a pending application for this license class.", 
                            "Pending Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (status == enAppStatus.Approved || status == enAppStatus.PassedAllTests || status == enAppStatus.LicenseIssued)
                    {
                        MessageBox.Show("This person already has an approved application or license for this class.", 
                            "License Already Issued", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("This person is not eligible to apply for this license class.", 
                            "Not Eligible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
                
                // Parse application fees
                decimal applicationFees = decimal.Parse(txtApplicationFees.Text.Replace("$", "").Trim());
                
                // Prepare Application EventArgs
                clsNewApplicationEventArgs applicationEventArgs = new clsNewApplicationEventArgs
                {
                    ApplicantPersonID = _selectedPersonID,
                    ApplicationCreatedDate = datePickerApplicationDate.Value,
                    ApplicationTypeID = licenseClassID,  // Use the actual license class ID selected
                    ApplicationStatus = enAppStatus.New,
                    ApplicationModifiedDate = DateTime.Now,
                    PaidFees = applicationFees,
                    CreatedByUserID = clsCurrentSession.LoggedInUserID
                };

                // Save the application
                int addedApplicationID = clsApplicationsBusinessLayer.AddNewApplication(applicationEventArgs);
                if (addedApplicationID > 0)
                {
                    MessageBox.Show($"License application added successfully with Application ID: {addedApplicationID}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"{ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void comboBoxLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(comboBoxLicenseClass, "");
        }
    }
}
