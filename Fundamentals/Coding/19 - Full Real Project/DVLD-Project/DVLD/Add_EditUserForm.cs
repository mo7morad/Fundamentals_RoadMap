using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BusinessLayer;
using Entities;
using Entities.Enums;

namespace DVLD
{
    public partial class Add_EditUserForm : Form
    {
        public event EventHandler OnSave;
        private int _selectedPersonID = -1;
        private clsPerson _selectedPerson = null;
        private clsUser _selectedUser = null;
        private TabPage _currentTabPage;
        private enFormMode _formMode;

        public Add_EditUserForm(enFormMode mode = enFormMode.AddNew)
        {
            _formMode = mode;
            InitializeComponent();
            SetupFormControls(mode);
            SetupTextChangeEvents();
        }

        public Add_EditUserForm(clsUser user, enFormMode mode)
        {
            InitializeComponent();

            if (user != null)
            {
                _selectedPersonID = user.PersonID;
                _selectedUser = user;
                _formMode = mode;
                _selectedPerson = user.PersonData;
            }

            SetupFormControls(mode);
            SetupTextChangeEvents();

            if (user != null && mode == enFormMode.Update)
            {
                DisplayPersonInfo(_selectedPerson);
                DisplayUserLoginInfo();
                btnNext.Enabled = true;
                panelFind.Enabled = false;
            }
        }

        private void SetupFormControls(enFormMode mode)
        {
            _currentTabPage = tabPagePersonalInfo;
            UpdateTabHeaderStyles();

            // Update form title based on mode
            if (mode == enFormMode.Update)
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";
            }
            else
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
            }

            // Only disable controls and clear fields if we're adding a new user with no person selected
            if (_formMode == enFormMode.AddNew && _selectedPersonID <= 0)
            {
                btnNext.Enabled = false;
                btnSave.Enabled = false;
                ClearPersonFields();
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

        private void txtFindValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                btnFindPerson_Click(sender, e);
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

        private void DisplayUserLoginInfo()
        {
            if (_selectedUser != null)
            {
                lblUserID.Text = _selectedUser.UserID.ToString();
                txtUsername.Text = _selectedUser.UserName;
                txtPassword.Text = _selectedUser.Password;
                txtConfirmPassword.Text = _selectedUser.Password;
                checkBoxIsActive.Checked = _selectedUser.IsActive;
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                checkBoxIsActive.Checked = true;
                lblUserID.Text = "[????]";
            }
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
            // In update mode, we always have a selected person
            if (_formMode == enFormMode.Update && _selectedUser != null)
            {
                Add_EditPersonForm frm = new Add_EditPersonForm(enFormMode.Update, _selectedPersonID);
                frm.PersonSavedToDataBase += (s, args) =>
                {
                    _selectedPerson = clsPeopleBusinessLayer.GetPersonByID(_selectedPersonID);
                    DisplayPersonInfo(_selectedPerson);
                };
                frm.ShowDialog();
                return;
            }

            // For add mode or if somehow we don't have a user in update mode
            if (_selectedPersonID <= 0)
            {
                MessageBox.Show("Please select a person first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Add_EditPersonForm frm2 = new Add_EditPersonForm(enFormMode.Update, _selectedPersonID);
            frm2.PersonSavedToDataBase += (s, args) =>
            {
                _selectedPerson = clsPeopleBusinessLayer.GetPersonByID(_selectedPersonID);
                DisplayPersonInfo(_selectedPerson);
            };
            frm2.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Skip the check for existing user if in Update mode since we're updating the current user
            if (_formMode == enFormMode.AddNew && _selectedPersonID > 0 && clsUsersBusinessLayer.IsUserExist(_selectedPersonID))
            {
                MessageBox.Show("User already exists. Please select a different person.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            linkLabelPersonalInfo.Font = (_currentTabPage == tabPagePersonalInfo)
                ? new Font(linkLabelPersonalInfo.Font, FontStyle.Bold)
                : new Font(linkLabelPersonalInfo.Font, FontStyle.Regular);

            linkLabelLoginInfo.Font = (_currentTabPage == tabPageLoginInfo)
                ? new Font(linkLabelLoginInfo.Font, FontStyle.Bold)
                : new Font(linkLabelLoginInfo.Font, FontStyle.Regular);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // In update mode, we already have a selected person/user
            if (_formMode == enFormMode.Update && _selectedUser != null)
            {
                if (!ValidateLoginInputs())
                {
                    MessageBox.Show("Please fix the validation errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string usrname = txtUsername.Text;

                if (_selectedUser.UserName != usrname && clsUsersBusinessLayer.IsUserNameExists(usrname))
                {
                    errorProviderLogin.SetError(txtUsername, "Username already exists. Please choose a different username.");
                    return;
                }

                try
                {
                    _selectedUser.UserName = usrname;
                    _selectedUser.Password = txtPassword.Text;
                    _selectedUser.IsActive = checkBoxIsActive.Checked;

                    // Make sure PersonID is set correctly
                    _selectedUser.PersonID = _selectedPersonID;

                    string errorMessage = String.Empty;

                    if (clsUsersBusinessLayer.UpdateUser(_selectedUser, ref errorMessage))
                    {
                        MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        OnSave?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show($"Failed to update user: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }

            // For add mode
            if (_selectedPersonID <= 0)
            {
                MessageBox.Show("Please select a person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateLoginInputs())
            {
                MessageBox.Show("Please fix the validation errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txtUsername.Text;

            if (clsUsersBusinessLayer.IsUserNameExists(username))
            {
                errorProviderLogin.SetError(txtUsername, "Username already exists. Please choose a different username.");
                return;
            }

            try
            {
                string errorMessage = string.Empty;
                clsUser newUser = new clsUser(_selectedPersonID, username, txtPassword.Text, checkBoxIsActive.Checked);
                int userID = clsUsersBusinessLayer.AddNewUser(newUser, ref errorMessage);

                if (userID > 0)
                {
                    lblUserID.Text = userID.ToString();
                    MessageBox.Show($"User added successfully with ID: {userID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    OnSave?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show($"Failed to add user: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLoginInputs()
        {
            errorProviderLogin.Clear();

            bool isUsernameValid = ValidateUsername();
            bool isPasswordValid = ValidatePassword();
            bool isConfirmPasswordValid = ValidateConfirmPassword();

            return isUsernameValid && isPasswordValid && isConfirmPasswordValid;
        }

        private bool ValidateUsername()
        {
            string username = txtUsername.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(username))
            {
                errorProviderLogin.SetError(txtUsername, "Username is required.");
                return false;
            }
            
            if (username.Length < 3)
            {
                errorProviderLogin.SetError(txtUsername, "Username must be at least 3 characters.");
                return false;
            }
            
            // Check if username exists (only in Add mode or if username changed in Update mode)
            if (_formMode == enFormMode.AddNew || 
                (_formMode == enFormMode.Update && _selectedUser != null && _selectedUser.UserName != username))
            {
                if (clsUsersBusinessLayer.IsUserNameExists(username))
                {
                    errorProviderLogin.SetError(txtUsername, "Username already exists. Please choose a different username.");
                    return false;
                }
            }
            
            return true;
        }

        private bool ValidatePassword()
        {
            string password = txtPassword.Text;
            
            if (string.IsNullOrWhiteSpace(password))
            {
                errorProviderLogin.SetError(txtPassword, "Password is required.");
                return false;
            }
            
            if (password.Length < 6)
            {
                errorProviderLogin.SetError(txtPassword, "Password must be at least 6 characters.");
                return false;
            }

            // Password complexity check - uncomment if needed
            //if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$"))
            //{
            //    errorProviderLogin.SetError(txtPassword, "Password must contain at least one uppercase letter, one lowercase letter, and one number.");
            //    return false;
            //}
            
            // If confirm password is already filled, check if they match
            if (!string.IsNullOrEmpty(txtConfirmPassword.Text) && password != txtConfirmPassword.Text)
            {
                errorProviderLogin.SetError(txtConfirmPassword, "Passwords do not match.");
                return false;
            }
            
            return true;
        }

        private bool ValidateConfirmPassword()
        {
            string confirmPassword = txtConfirmPassword.Text;
            string password = txtPassword.Text;
            
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                errorProviderLogin.SetError(txtConfirmPassword, "Confirm password is required.");
                return false;
            }
            
            if (password != confirmPassword)
            {
                errorProviderLogin.SetError(txtConfirmPassword, "Passwords do not match.");
                return false;
            }
            
            return true;
        }

        private void SetupTextChangeEvents()
        {
            txtUsername.TextChanged += LoginFieldTextChanged;
            txtPassword.TextChanged += LoginFieldTextChanged;
            txtConfirmPassword.TextChanged += LoginFieldTextChanged;
            
            txtUsername.Leave += LoginFieldLeave;
            txtPassword.Leave += LoginFieldLeave;
            txtConfirmPassword.Leave += LoginFieldLeave;
        }

        private void LoginFieldTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            // Clear error when user starts typing
            errorProviderLogin.SetError(textBox, "");
        }

        private void LoginFieldLeave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            if (textBox == txtUsername)
            {
                ValidateUsername();
            }
            else if (textBox == txtPassword)
            {
                ValidatePassword();
            }
            else if (textBox == txtConfirmPassword)
            {
                ValidateConfirmPassword();
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

        private void linkLabelLoginInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Skip the person selection validation if we're in Update mode and already have a user selected
            if (_formMode == enFormMode.Update && _selectedUser != null)
            {
                // We already have a user, so just navigate to the login info tab
                tabControl.SelectedTab = tabPageLoginInfo;
                _currentTabPage = tabPageLoginInfo;
                btnNext.Text = "Back";
                btnSave.Enabled = true;
                UpdateTabHeaderStyles();
                return;
            }

            // This is the original validation check for Add mode
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
            // if enter key is pressed, trigger the find button click
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnFindPerson_Click(sender, e);
            }
        }
    }
}
