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
            var credentials = clsUsersBusinessLayer.LoadCredentials();
            if (credentials.username != null && credentials.password != null)
            {
                txtUsername.Text = credentials.username;
                txtPassword.Text = credentials.password;
            }
        }
        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                clsUsersBusinessLayer.SaveCredentials(txtUsername.Text, txtPassword.Text);
            }
        }
    }
}
