using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BusinessLayer;
using Entities;

namespace DVLD
{
    public partial class ChangePasswordForm : Form
    {
        private clsUser _currentUser;
        private ErrorProvider errorProvider;

        public ChangePasswordForm()
        {
            InitializeComponent(0);
            SetupErrorProvider();
            SetupTextChangeEvents();
        }

        public ChangePasswordForm(clsUser user)
        {
            _currentUser = user;
            InitializeComponent(user.PersonData.PersonID);
            PopulateUserLoginInfo(user);
            SetupErrorProvider();
            SetupTextChangeEvents();
        }

        private void SetupErrorProvider()
        {
            // Initialize error provider
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void SetupTextChangeEvents()
        {
            // Add event handlers for text change events
            txtBoxCurrentPassword.TextChanged += PasswordFieldTextChanged;
            txtBoxNewPassword.TextChanged += PasswordFieldTextChanged;
            txtBoxConfirmPassword.TextChanged += PasswordFieldTextChanged;

            // Add event handlers for leave events
            txtBoxCurrentPassword.Leave += PasswordFieldLeave;
            txtBoxNewPassword.Leave += PasswordFieldLeave;
            txtBoxConfirmPassword.Leave += PasswordFieldLeave;
        }

        private void PasswordFieldTextChanged(object sender, EventArgs e)
        {
            // Clear error when user starts typing
            if (sender is MaskedTextBox maskedTextBox)
            {
                errorProvider.SetError(maskedTextBox, "");
            }
        }

        private void PasswordFieldLeave(object sender, EventArgs e)
        {
            if (sender is MaskedTextBox maskedTextBox)
            {
                if (maskedTextBox == txtBoxCurrentPassword)
                {
                    ValidateCurrentPassword();
                }
                else if (maskedTextBox == txtBoxNewPassword)
                {
                    ValidateNewPassword();
                }
                else if (maskedTextBox == txtBoxConfirmPassword)
                {
                    ValidateConfirmPassword();
                }
            }
        }

        private bool ValidateCurrentPassword()
        {
            string currentPassword = txtBoxCurrentPassword.Text;

            if (string.IsNullOrWhiteSpace(currentPassword))
            {
                errorProvider.SetError(txtBoxCurrentPassword, "Current password is required.");
                return false;
            }

            // Verify the current password matches the user's actual password
            if (_currentUser != null && currentPassword != _currentUser.Password)
            {
                errorProvider.SetError(txtBoxCurrentPassword, "Current password is incorrect.");
                return false;
            }

            return true;
        }

        private bool ValidateNewPassword()
        {
            string newPassword = txtBoxNewPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                errorProvider.SetError(txtBoxNewPassword, "New password is required.");
                return false;
            }

            if (newPassword.Length < 6)
            {
                errorProvider.SetError(txtBoxNewPassword, "Password must be at least 6 characters.");
                return false;
            }

            // Optional: Password complexity check
            //if (!Regex.IsMatch(newPassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$"))
            //{
            //    errorProvider.SetError(txtBoxNewPassword, "Password must contain at least one uppercase letter, one lowercase letter, and one number.");
            //    return false;
            //}

            // Check that new password is different from current
            if (_currentUser != null && newPassword == _currentUser.Password)
            {
                errorProvider.SetError(txtBoxNewPassword, "New password must be different from current password.");
                return false;
            }

            // If confirm password is already filled, check if they match
            if (!string.IsNullOrEmpty(txtBoxConfirmPassword.Text) && newPassword != txtBoxConfirmPassword.Text)
            {
                errorProvider.SetError(txtBoxConfirmPassword, "Passwords do not match.");
                return false;
            }

            return true;
        }

        private bool ValidateConfirmPassword()
        {
            string confirmPassword = txtBoxConfirmPassword.Text;
            string newPassword = txtBoxNewPassword.Text;

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                errorProvider.SetError(txtBoxConfirmPassword, "Confirm password is required.");
                return false;
            }

            if (newPassword != confirmPassword)
            {
                errorProvider.SetError(txtBoxConfirmPassword, "Passwords do not match.");
                return false;
            }

            return true;
        }

        private bool ValidateAllInputs()
        {
            errorProvider.Clear();

            bool isCurrentPasswordValid = ValidateCurrentPassword();
            bool isNewPasswordValid = ValidateNewPassword();
            bool isConfirmPasswordValid = ValidateConfirmPassword();

            return isCurrentPasswordValid && isNewPasswordValid && isConfirmPasswordValid;
        }

        private void PopulateUserLoginInfo(clsUser user)
        {
            lblUserID.Text += user.UserID.ToString();
            lblUserName.Text += user.UserName;
            lblIsActive.Text += user.IsActive ? "Yes" : "No";
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateAllInputs())
            {
                MessageBox.Show("Please fix the validation errors before saving.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string errorMessage = string.Empty;
                string newPassword = txtBoxNewPassword.Text;

                if (clsUsersBusinessLayer.ChangeUserPassword(_currentUser.UserID,
                    Convert.ToInt32(newPassword), ref errorMessage))
                {
                    MessageBox.Show("Password changed successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update the stored password in the current user object
                    _currentUser.Password = newPassword;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Failed to change password: {errorMessage}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing password: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
