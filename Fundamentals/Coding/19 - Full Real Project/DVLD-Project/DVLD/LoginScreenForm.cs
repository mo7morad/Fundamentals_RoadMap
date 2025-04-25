using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class LoginScreenForm : Form
    {
        // You can use these for actual login implementation
        private const string DefaultUsername = "admin";
        private const string DefaultPassword = "password";

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Here you would implement actual authentication logic
            // This is a placeholder implementation
            if (txtUsername.Text == DefaultUsername && txtPassword.Text == DefaultPassword)
            {
                // Authentication successful
                MessageBox.Show("Login successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Note: If MainScreenForm doesn't exist yet, comment out or modify these lines
                // this.Hide();
                // MainScreenForm mainForm = new MainScreenForm();
                // mainForm.FormClosed += (s, args) => this.Close();
                // mainForm.Show();
            }
            else
            {
                // Authentication failed
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
