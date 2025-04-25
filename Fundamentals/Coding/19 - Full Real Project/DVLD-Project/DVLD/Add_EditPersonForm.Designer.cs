using DVLD_Entities.Enums;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DVLD
{
    partial class Add_EditPersonForm
    {
        // Import for moving the window
        [DllImport("user32.dll")]
        public static extern int SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void InitializeComponent(enFormMode formMode, int personID = -1)
        {
            this.usrCtrlAdd_EditPerson = new usrCtrlPerson(formMode, personID);
            this.SuspendLayout();
            // 
            // usrCtrlAdd_EditPerson (Control Add New Setup)
            // 
            if (formMode == enFormMode.AddNew)
            {
                this.usrCtrlAdd_EditPerson.Address = "";
                this.usrCtrlAdd_EditPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.usrCtrlAdd_EditPerson.Country = "";
                this.usrCtrlAdd_EditPerson.DateOfBirth = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
                this.usrCtrlAdd_EditPerson.Dock = System.Windows.Forms.DockStyle.Fill;
                this.usrCtrlAdd_EditPerson.Email = "";
                this.usrCtrlAdd_EditPerson.FirstName = "";
                this.usrCtrlAdd_EditPerson.Gender = false;
                this.usrCtrlAdd_EditPerson.ImagePath = null;
                this.usrCtrlAdd_EditPerson.LastName = "";
                this.usrCtrlAdd_EditPerson.Location = new System.Drawing.Point(0, 0);
                this.usrCtrlAdd_EditPerson.Name = "usrCtrlAdd_EditPerson";
                this.usrCtrlAdd_EditPerson.NationalNumber = "";
                this.usrCtrlAdd_EditPerson.PersonID = "N/A";
                this.usrCtrlAdd_EditPerson.Phone = "";
                this.usrCtrlAdd_EditPerson.SecondName = "";
                this.usrCtrlAdd_EditPerson.Size = new System.Drawing.Size(750, 480);
                this.usrCtrlAdd_EditPerson.TabIndex = 0;
                this.usrCtrlAdd_EditPerson.ThirdName = "";
            }
            // 
            // Add_EditPersonForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.usrCtrlAdd_EditPerson);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "Add_EditPersonForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Set form title based on mode with modern styling
            string titleText = formMode == enFormMode.Update ? "Update Person" : "Add New Person";
            this.Text = titleText;

            // Apply modern shadow effect
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Modern rounded form
            System.Windows.Forms.Panel panelContainer = new System.Windows.Forms.Panel();
            panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContainer.BackColor = System.Drawing.Color.White;
            panelContainer.Padding = new System.Windows.Forms.Padding(1);
            this.Controls.Add(panelContainer);

            // Title bar
            System.Windows.Forms.Panel titleBar = new System.Windows.Forms.Panel();
            titleBar.BackColor = System.Drawing.Color.FromArgb(45, 50, 80);
            titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            titleBar.Height = 40;

            // Title label
            System.Windows.Forms.Label titleLabel = new System.Windows.Forms.Label();
            titleLabel.Text = titleText;
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            titleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            titleLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            titleBar.Controls.Add(titleLabel);

            // Close button
            System.Windows.Forms.Button closeButton = new System.Windows.Forms.Button();
            closeButton.Text = "✕";
            closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Size = new System.Drawing.Size(40, 40);
            closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            closeButton.ForeColor = System.Drawing.Color.White;
            closeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            closeButton.Click += (s, e) => this.Close();
            titleBar.Controls.Add(closeButton);

            // Add title bar to container
            panelContainer.Controls.Add(titleBar);

            // Add the user control to container
            this.usrCtrlAdd_EditPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContainer.Controls.Add(this.usrCtrlAdd_EditPerson);

            // Make sure user control is on top of z-order
            this.usrCtrlAdd_EditPerson.BringToFront();

            // Enable form movement by dragging the title bar
            titleBar.MouseDown += (s, e) => {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    const int WM_NCLBUTTONDOWN = 0xA1;
                    const int HTCAPTION = 0x2;
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            };

            this.ResumeLayout(false);
        }

        private usrCtrlPerson usrCtrlAdd_EditPerson;
    }
}
