using Entities;
using System;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD
{
    public partial class LoginScreenForm : Form
    {
        // You can use these for actual login implementation
        private string DefaultUsername;
        private string DefaultPassword;

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
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            bool isUserExists = clsUsersBusinessLayer.IsUserNameExists(userName);
            if (!isUserExists)
            {
                return false;
            }

            clsUser user = clsUsersBusinessLayer.GetUserByUserName(userName);
            if (user != null)
            {
                if(user.Status == false)
                {
                    MessageBox.Show("User is inactive. Please contact support.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return user.Password == password;
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
                MessageBox.Show("Login successful!", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                MainScreenForm mainForm = new MainScreenForm();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
            }
        }
    }
}
