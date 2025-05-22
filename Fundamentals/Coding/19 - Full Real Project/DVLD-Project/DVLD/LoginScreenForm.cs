using Entities;
using System;
using System.Windows.Forms;
using BusinessLayer;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DVLD
{
    public partial class LoginScreenForm : Form
    {

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
            // if the username or password are empty, return false
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            // Check if the user exists in the database
            bool isUserExists = clsUsersBusinessLayer.IsUserNameExists(userName);
            if (!isUserExists)
            {
                return false;
            }

            // if user exists, check the status (active or not).
            clsUser user = clsUsersBusinessLayer.GetUserByUserName(userName);
            if (user != null)
            {
                if (user.IsActive == false)
                {
                    MessageBox.Show("User is inactive.\n Please contact support.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if(user.Password == password)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
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
            // Check if the credentials file exists
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DVLD", "credentials.dat");
            if (File.Exists(filePath))
            {
                byte[] encryptedData = File.ReadAllBytes(filePath);
                byte[] decryptedData = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
                string credentials = Encoding.UTF8.GetString(decryptedData);
                string[] parts = credentials.Split(':');
                if (parts.Length == 2)
                {
                    txtUsername.Text = parts[0];
                    txtPassword.Text = parts[1];
                }
            }
        }
        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DVLD", "credentials.dat");
                string username = txtUsername.Text.ToLower();
                string password = txtPassword.Text;

                string combinedCredentials = $"{username}:{password}";
                byte[] data = Encoding.UTF8.GetBytes(combinedCredentials);
                byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);

                File.WriteAllBytes(filePath, encrypted);
            }
        }
    }
}
