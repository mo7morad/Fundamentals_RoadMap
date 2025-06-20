using Entities;
using System;
using System.Windows.Forms;
using BusinessLayer;
using Microsoft.Win32;

namespace DVLD
{
    public partial class LoginScreenForm : Form
    {
        // Registry keys and paths
        private const string RegistryPath = @"Software\DVLD";
        private const string UsernameKey = "LastUsername";
        private const string PasswordKey = "LastPassword";
        private const string RememberMeKey = "RememberMe";

        public LoginScreenForm()
        {
            InitializeComponent();

            // Add window drag capability
            this.leftPanel.MouseDown += Panel_MouseDown;
            this.rightPanel.MouseDown += Panel_MouseDown;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Allow dragging the form
                const int WM_NCLBUTTONDOWN = 0xA1;
                const int HTCAPTION = 0x2;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        // Import for moving the window
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool UserValidation(string userName, string password)
        {
            bool isAuthenticated = clsUsersBusinessLayer.AuthenticateUser(userName, password);

            if (!isAuthenticated)
            {
                // Only show message if username exists but authentication failed (wrong password or inactive)
                if (clsUsersBusinessLayer.IsUserNameExists(userName))
                {
                    clsUser user = clsUsersBusinessLayer.GetUserByUserName(userName);
                    if (user != null && !user.IsActive)
                    {
                        MessageBox.Show("User is inactive.\n Please contact support.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return isAuthenticated;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserValidation(txtUsername.Text, txtPassword.Text))
            {
                // Save credentials if Remember Me is checked
                if (chkRememberMe.Checked)
                {
                    SaveCredentialsToRegistry(txtUsername.Text, txtPassword.Text);
                }
                else
                {
                    // Clear any saved credentials if not remembering
                    ClearCredentialsFromRegistry();
                }

                // Authentication successful
                string errorMsg = String.Empty;
                clsCurrentSession.LoggedInUserName = txtUsername.Text.ToLower();
                clsCurrentSession.LoggedInUserID = clsUsersBusinessLayer.GetUserIDByUserName(txtUsername.Text.ToLower(), ref errorMsg);
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainScreenForm mainForm = new MainScreenForm();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
            }
        }

        private void LoginScreenForm_Load(object sender, EventArgs e)
        {
            LoadCredentialsFromRegistry();
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            // If Remember Me is checked and we have credentials, save them
            if (chkRememberMe.Checked &&
                !string.IsNullOrEmpty(txtUsername.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text))
            {
                SaveCredentialsToRegistry(txtUsername.Text, txtPassword.Text);
            }
            else if (!chkRememberMe.Checked)
            {
                // Clear saved credentials if unchecked
                ClearCredentialsFromRegistry();
            }
        }

        #region Registry Methods

        private void SaveCredentialsToRegistry(string username, string password)
        {
            try
            {
                RegistryKey baseKey = Registry.CurrentUser;
                RegistryKey key = baseKey.CreateSubKey(RegistryPath);

                // Save the credentials
                key?.SetValue(UsernameKey, username);
                key?.SetValue(PasswordKey, password);
                key?.SetValue(RememberMeKey, true);

                key?.Close();
                baseKey.Close();
            }
            catch (Exception ex)
            {
                // Handle any registry access errors
                Console.WriteLine($"Error saving credentials to registry: {ex.Message}");
            }
        }

        private void LoadCredentialsFromRegistry()
        {
            try
            {
                RegistryKey baseKey = Registry.CurrentUser;
                RegistryKey key = baseKey.OpenSubKey(RegistryPath);

                if (key != null)
                {
                    // Check if Remember Me was enabled
                    object rememberMeValue = key.GetValue(RememberMeKey);
                    bool rememberMe = rememberMeValue != null && Convert.ToBoolean(rememberMeValue);

                    if (rememberMe)
                    {
                        // Get saved username and password
                        object usernameValue = key.GetValue(UsernameKey);
                        object passwordValue = key.GetValue(PasswordKey);

                        if (usernameValue != null)
                            txtUsername.Text = usernameValue.ToString();

                        if (passwordValue != null)
                            txtPassword.Text = passwordValue.ToString();

                        // Set the checkbox
                        chkRememberMe.Checked = true;
                    }

                    key.Close();
                }

                baseKey.Close();
            }
            catch (Exception ex)
            {
                // Handle any registry access errors
                Console.WriteLine($"Error loading credentials from registry: {ex.Message}");
            }
        }

        private void ClearCredentialsFromRegistry()
        {
            try
            {
                RegistryKey baseKey = Registry.CurrentUser;
                RegistryKey key = baseKey.OpenSubKey(RegistryPath, true);

                if (key != null)
                {
                    // Delete the values (not the key itself)
                    key.DeleteValue(UsernameKey, false);
                    key.DeleteValue(PasswordKey, false);
                    key.SetValue(RememberMeKey, false);

                    key.Close();
                }

                baseKey.Close();
            }
            catch (Exception ex)
            {
                // Handle any registry access errors
                Console.WriteLine($"Error clearing credentials from registry: {ex.Message}");
            }
        }

        #endregion
    }
}
