namespace DVLD
{
    partial class ChangePasswordForm
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
        private void InitializeComponent(int personID)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.groupBoxLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtBoxCurrentPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxNewPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxConfirmPassword = new System.Windows.Forms.MaskedTextBox();
            this.usrCtrlPersonInfoCard = new DVLD.usrCtrlPersonInfoCard(personID);
            this.groupBoxLoginInfo.SuspendLayout();
            this.panelChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLoginInfo
            // 
            this.groupBoxLoginInfo.Controls.Add(this.lblIsActive);
            this.groupBoxLoginInfo.Controls.Add(this.lblUserName);
            this.groupBoxLoginInfo.Controls.Add(this.lblUserID);
            this.groupBoxLoginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLoginInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoginInfo.Location = new System.Drawing.Point(0, 322);
            this.groupBoxLoginInfo.Name = "groupBoxLoginInfo";
            this.groupBoxLoginInfo.Size = new System.Drawing.Size(1050, 269);
            this.groupBoxLoginInfo.TabIndex = 1;
            this.groupBoxLoginInfo.TabStop = false;
            this.groupBoxLoginInfo.Text = "Login Info";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(227, 25);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(69, 21);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID: ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(447, 25);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(91, 21);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Username: ";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(687, 25);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(78, 21);
            this.lblIsActive.TabIndex = 2;
            this.lblIsActive.Text = "Is Active: ";
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.btnSave);
            this.panelChangePassword.Controls.Add(this.txtBoxConfirmPassword);
            this.panelChangePassword.Controls.Add(this.txtBoxNewPassword);
            this.panelChangePassword.Controls.Add(this.txtBoxCurrentPassword);
            this.panelChangePassword.Controls.Add(this.lblConfirmPassword);
            this.panelChangePassword.Controls.Add(this.lblNewPassword);
            this.panelChangePassword.Controls.Add(this.lblCurrentPassword);
            this.panelChangePassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChangePassword.Location = new System.Drawing.Point(0, 406);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(1050, 185);
            this.panelChangePassword.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(415, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(37, 30);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(151, 20);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(63, 82);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(125, 20);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(35, 136);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(153, 20);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtBoxCurrentPassword
            // 
            this.txtBoxCurrentPassword.Location = new System.Drawing.Point(212, 30);
            this.txtBoxCurrentPassword.Name = "txtBoxCurrentPassword";
            this.txtBoxCurrentPassword.PasswordChar = '*';
            this.txtBoxCurrentPassword.Size = new System.Drawing.Size(156, 20);
            this.txtBoxCurrentPassword.TabIndex = 3;
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Location = new System.Drawing.Point(212, 82);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.PasswordChar = '*';
            this.txtBoxNewPassword.Size = new System.Drawing.Size(156, 20);
            this.txtBoxNewPassword.TabIndex = 4;
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(212, 136);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.PasswordChar = '*';
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(156, 20);
            this.txtBoxConfirmPassword.TabIndex = 5;
            // 
            // usrCtrlPersonInfoCard
            // 
            this.usrCtrlPersonInfoCard.OnCloseClicked += new System.EventHandler(this.OnCloseClicked);
            this.usrCtrlPersonInfoCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.usrCtrlPersonInfoCard.Location = new System.Drawing.Point(0, 0);
            this.usrCtrlPersonInfoCard.PersonImage = ((System.Drawing.Image)(resources.GetObject("usrCtrlPersonInfoCard.PersonImage")));
            this.usrCtrlPersonInfoCard.Size = new System.Drawing.Size(1050, 322);
            this.usrCtrlPersonInfoCard.TabIndex = 0;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 591);
            this.Controls.Add(this.panelChangePassword);
            this.Controls.Add(this.groupBoxLoginInfo);
            this.Controls.Add(this.usrCtrlPersonInfoCard);
            this.Name = "ChangePasswordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.groupBoxLoginInfo.ResumeLayout(false);
            this.groupBoxLoginInfo.PerformLayout();
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private usrCtrlPersonInfoCard usrCtrlPersonInfoCard;
        private System.Windows.Forms.GroupBox groupBoxLoginInfo;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Panel panelChangePassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MaskedTextBox txtBoxConfirmPassword;
        private System.Windows.Forms.MaskedTextBox txtBoxNewPassword;
        private System.Windows.Forms.MaskedTextBox txtBoxCurrentPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
    }
}