using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using Entities;
using DVLD_Entities.Enums;

namespace DVLD
{
    public partial class AddNewUserForm : Form
    {
        private int _selectedPersonID = -1;
        private clsPerson _selectedPerson = null;
        private TabPage _currentTabPage;

        public AddNewUserForm()
        {
            InitializeComponent();
            SetupFormControls();
        }

        private void SetupFormControls()
        {
            // Initialize data
            comboBoxFindBy.Items.AddRange(new string[] { "National No", "Person ID", "Name" });
            comboBoxFindBy.SelectedIndex = 0;

            // Set initial state
            _currentTabPage = tabPagePersonalInfo;
            UpdateTabHeaderStyles();
            btnNext.Enabled = false;
            btnSave.Enabled = false;

            // Clear person fields
            ClearPersonFields();
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
                else if (findBy == "Name")
                {
                    // Open a form to select from multiple people with similar names
                    // For now, we'll assume we get back a single person
                    MessageBox.Show("Feature not fully implemented. Please use Person ID or National No.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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

            lblPersonID.Text = person.PersonID.ToString();
            lblPersonName.Text = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            lblNationalNo.Text = person.NationalNo;
            lblGender.Text = person.Gender ? "Female" : "Male";
            lblEmail.Text = person.Email ?? "[None]";
            lblAddress.Text = person.Address;
            lblDateOfBirth.Text = person.DateOfBirth.ToString("dd/MM/yyyy");
            lblPhone.Text = person.Phone;
            lblCountry.Text = person.Country?.CountryName ?? "[Unknown]";

            // Load person image if available
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

        private void linkLabelAddNewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_EditPersonForm frm = new Add_EditPersonForm(enFormMode.AddNew);
            frm.PersonSavedToDataBase += (s, args) =>
            {
                // Refresh person data
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
                tabControl.SelectedTab = tabPageLoginInfo;
                _currentTabPage = tabPageLoginInfo;
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

        private void UpdateTabHeaderStyles()
        {
            // UI exp. Change the appearance of the tab headers based on the current tab
            linkLabelPersonalInfo.Font = (_currentTabPage == tabPagePersonalInfo) ?
                new Font(linkLabelPersonalInfo.Font, FontStyle.Bold) :
                new Font(linkLabelPersonalInfo.Font, FontStyle.Regular);

            linkLabelLoginInfo.Font = (_currentTabPage == tabPageLoginInfo) ?
                new Font(linkLabelLoginInfo.Font, FontStyle.Bold) :
                new Font(linkLabelLoginInfo.Font, FontStyle.Regular);
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    if (_selectedPersonID <= 0)
        //    {
        //        MessageBox.Show("Please select a person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
        //    {
        //        MessageBox.Show("Username and Password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (txtPassword.Text != txtConfirmPassword.Text)
        //    {
        //        MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (clsUsersBusinessLayer.IsUserNameExists(txtUsername.Text))
        //    {
        //        MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    try
        //    {
        //        // Create a new user object
        //        Entities.clsUser user = new clsUser();
        //        user.PersonID = _selectedPersonID;
        //        user.UserName = txtUsername.Text;
        //        user.Password = txtPassword.Text;
        //        user.Status = checkBoxIsActive.Checked;

        //        string errorMessage = string.Empty;
        //        int userID = clsUsersBusinessLayer.AddNewUser(user, ref errorMessage);

        //        if (userID > 0)
        //        {
        //            MessageBox.Show($"User added successfully with ID: {userID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.DialogResult = DialogResult.OK;
        //            this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show($"Failed to add user: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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

        private void linkLabelLoginInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_selectedPersonID <= 0)
            {
                MessageBox.Show("Please select a person first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tabControl.SelectedTab = tabPageLoginInfo;
            _currentTabPage = tabPageLoginInfo;
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
            if (comboBoxFindBy.Text == "Person ID")
            {
                // Allow only digits
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            }
            else
            {
                // Allow all characters
                e.Handled = false;
            }
        }
    }
}
