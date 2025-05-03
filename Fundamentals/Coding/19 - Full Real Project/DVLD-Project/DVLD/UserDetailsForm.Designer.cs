namespace DVLD
{
    partial class UserDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetailsForm));
            this.Text = "User Details";
            this.usrCtrlPersonInfoCard = new DVLD.usrCtrlPersonInfoCard(personID);
            this.groupBoxUserLoginInfo = new System.Windows.Forms.GroupBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.groupBoxUserLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // usrCtrlPersonInfoCard
            // 
            this.usrCtrlPersonInfoCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.usrCtrlPersonInfoCard.Location = new System.Drawing.Point(0, 0);
            this.usrCtrlPersonInfoCard.PersonImage = ((System.Drawing.Image)(resources.GetObject("usrCtrlPersonInfoCard.PersonImage")));
            this.usrCtrlPersonInfoCard.Size = new System.Drawing.Size(1047, 343);
            this.usrCtrlPersonInfoCard.TabIndex = 0;
            this.usrCtrlPersonInfoCard.OnCloseClicked += new System.EventHandler(this.OnCloseClicked);
            // 
            // groupBoxUserLoginInfo
            // 
            this.groupBoxUserLoginInfo.Controls.Add(this.lblUserName);
            this.groupBoxUserLoginInfo.Controls.Add(this.lblIsActive);
            this.groupBoxUserLoginInfo.Controls.Add(this.lblUserID);
            this.groupBoxUserLoginInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxUserLoginInfo.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserLoginInfo.Location = new System.Drawing.Point(0, 350);
            this.groupBoxUserLoginInfo.Name = "groupBoxUserLoginInfo";
            this.groupBoxUserLoginInfo.Size = new System.Drawing.Size(1047, 100);
            this.groupBoxUserLoginInfo.TabIndex = 1;
            this.groupBoxUserLoginInfo.TabStop = false;
            this.groupBoxUserLoginInfo.Text = "LoginInfo";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(185, 41);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(84, 27);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID: ";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(711, 41);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(94, 27);
            this.lblIsActive.TabIndex = 1;
            this.lblIsActive.Text = "Is Active: ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(448, 41);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(104, 27);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username: ";
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.groupBoxUserLoginInfo);
            this.Controls.Add(this.usrCtrlPersonInfoCard);
            this.Name = "UserDetailsForm";
            this.Text = "User Details";
            this.groupBoxUserLoginInfo.ResumeLayout(false);
            this.groupBoxUserLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private usrCtrlPersonInfoCard usrCtrlPersonInfoCard;
        private System.Windows.Forms.GroupBox groupBoxUserLoginInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUserID;
    }
}