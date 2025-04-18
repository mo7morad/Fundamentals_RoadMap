namespace DVLD
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripApplicationsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPeopleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDriversItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripUsersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAccountSettingsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripApplicationsItem,
            this.menuStripPeopleItem,
            this.menuStripDriversItem,
            this.menuStripUsersItem,
            this.menuStripAccountSettingsItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(922, 25);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // menuStripApplicationsItem
            // 
            this.menuStripApplicationsItem.Image = global::DVLD.Properties.Resources.Applications;
            this.menuStripApplicationsItem.Name = "menuStripApplicationsItem";
            this.menuStripApplicationsItem.Size = new System.Drawing.Size(107, 21);
            this.menuStripApplicationsItem.Text = "Applications";
            // 
            // menuStripPeopleItem
            // 
            this.menuStripPeopleItem.Image = global::DVLD.Properties.Resources.PeopleMenusStrip;
            this.menuStripPeopleItem.Name = "menuStripPeopleItem";
            this.menuStripPeopleItem.Size = new System.Drawing.Size(76, 21);
            this.menuStripPeopleItem.Text = "People";
            this.menuStripPeopleItem.Click += new System.EventHandler(this.menuStripPeopleItem_Click);
            // 
            // menuStripDriversItem
            // 
            this.menuStripDriversItem.Image = global::DVLD.Properties.Resources.driver;
            this.menuStripDriversItem.Name = "menuStripDriversItem";
            this.menuStripDriversItem.Size = new System.Drawing.Size(77, 21);
            this.menuStripDriversItem.Text = "Drivers";
            // 
            // menuStripUsersItem
            // 
            this.menuStripUsersItem.Image = global::DVLD.Properties.Resources.users;
            this.menuStripUsersItem.Name = "menuStripUsersItem";
            this.menuStripUsersItem.Size = new System.Drawing.Size(69, 21);
            this.menuStripUsersItem.Text = "Users";
            // 
            // menuStripAccountSettingsItem
            // 
            this.menuStripAccountSettingsItem.Image = global::DVLD.Properties.Resources.settings3;
            this.menuStripAccountSettingsItem.Name = "menuStripAccountSettingsItem";
            this.menuStripAccountSettingsItem.Size = new System.Drawing.Size(132, 21);
            this.menuStripAccountSettingsItem.Text = "Account Settings";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.applicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("applicationToolStripMenuItem.Image")));
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.applicationToolStripMenuItem.Text = "Applications";
            // 
            // peopleMenuStripItem
            // 
            this.peopleMenuStripItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleMenuStripItem.Image")));
            this.peopleMenuStripItem.Name = "peopleMenuStripItem";
            this.peopleMenuStripItem.Size = new System.Drawing.Size(76, 21);
            this.peopleMenuStripItem.Text = "People";
            this.peopleMenuStripItem.Click += new System.EventHandler(this.peopleMenuStripItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("driversToolStripMenuItem.Image")));
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountSettingsToolStripMenuItem.Image")));
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(132, 21);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("applicationsToolStripMenuItem.Image")));
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleToolStripMenuItem.Image")));
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.peopleToolStripMenuItem.Text = "People";
            // 
            // driversToolStripMenuItem1
            // 
            this.driversToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("driversToolStripMenuItem1.Image")));
            this.driversToolStripMenuItem1.Name = "driversToolStripMenuItem1";
            this.driversToolStripMenuItem1.Size = new System.Drawing.Size(77, 21);
            this.driversToolStripMenuItem1.Text = "Drivers";
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem1.Image")));
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(69, 21);
            this.usersToolStripMenuItem1.Text = "Users";
            // 
            // accountSettingsToolStripMenuItem1
            // 
            this.accountSettingsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("accountSettingsToolStripMenuItem1.Image")));
            this.accountSettingsToolStripMenuItem1.Name = "accountSettingsToolStripMenuItem1";
            this.accountSettingsToolStripMenuItem1.Size = new System.Drawing.Size(132, 21);
            this.accountSettingsToolStripMenuItem1.Text = "Account Settings";
            // 
            // applicationToolStripMenuItem1
            // 
            this.applicationToolStripMenuItem1.Image = global::DVLD.Properties.Resources.Applications;
            this.applicationToolStripMenuItem1.Name = "applicationToolStripMenuItem1";
            this.applicationToolStripMenuItem1.Size = new System.Drawing.Size(107, 21);
            this.applicationToolStripMenuItem1.Text = "Applications";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(12, 45);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(33, 25);
            this.lblCurrentUser.TabIndex = 1;
            this.lblCurrentUser.Text = "lbl";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DVLD.Properties.Resources.DVLD_Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(922, 459);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.MainMenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver License Managment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuStripApplicationsItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripPeopleItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripDriversItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripUsersItem;
        private System.Windows.Forms.ToolStripMenuItem menuStripAccountSettingsItem;
        private System.Windows.Forms.Label lblCurrentUser;
    }
}