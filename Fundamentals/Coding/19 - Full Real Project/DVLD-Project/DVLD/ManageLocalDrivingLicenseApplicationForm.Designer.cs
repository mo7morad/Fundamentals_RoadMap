namespace DVLD
{
    partial class ManageLocalDrivingLicenseApplicationForm
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
            this.panelMainTitle = new System.Windows.Forms.Panel();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblManageLocalLicense = new System.Windows.Forms.Label();
            this.pictureBoxLocalLicense = new System.Windows.Forms.PictureBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewApplications = new System.Windows.Forms.DataGridView();
            this.panelMainTitle.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainTitle
            // 
            this.panelMainTitle.Controls.Add(this.pictureBoxLocalLicense);
            this.panelMainTitle.Controls.Add(this.lblManageLocalLicense);
            this.panelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMainTitle.Name = "panelMainTitle";
            this.panelMainTitle.Size = new System.Drawing.Size(880, 147);
            this.panelMainTitle.TabIndex = 0;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewApplications);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 147);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(880, 303);
            this.panelDataGridView.TabIndex = 1;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Controls.Add(this.lblRecords);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 401);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(880, 49);
            this.panelFooter.TabIndex = 2;
            // 
            // lblManageLocalLicense
            // 
            this.lblManageLocalLicense.AutoSize = true;
            this.lblManageLocalLicense.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageLocalLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageLocalLicense.Location = new System.Drawing.Point(299, 105);
            this.lblManageLocalLicense.Name = "lblManageLocalLicense";
            this.lblManageLocalLicense.Size = new System.Drawing.Size(348, 30);
            this.lblManageLocalLicense.TabIndex = 0;
            this.lblManageLocalLicense.Text = "Local Driving License Applications";
            // 
            // pictureBoxLocalLicense
            // 
            this.pictureBoxLocalLicense.Image = global::DVLD.Properties.Resources.Manage_Applications_641;
            this.pictureBoxLocalLicense.Location = new System.Drawing.Point(396, 12);
            this.pictureBoxLocalLicense.Name = "pictureBoxLocalLicense";
            this.pictureBoxLocalLicense.Size = new System.Drawing.Size(150, 90);
            this.pictureBoxLocalLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLocalLicense.TabIndex = 1;
            this.pictureBoxLocalLicense.TabStop = false;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 19);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(91, 21);
            this.lblRecords.TabIndex = 0;
            this.lblRecords.Text = "# Records: ";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(775, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dataGridViewApplications
            // 
            this.dataGridViewApplications.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewApplications.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewApplications.Name = "dataGridViewApplications";
            this.dataGridViewApplications.Size = new System.Drawing.Size(880, 303);
            this.dataGridViewApplications.TabIndex = 0;
            // 
            // ManageLocalDrivingLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelMainTitle);
            this.Name = "ManageLocalDrivingLicenseApplicationForm";
            this.Text = "Manage Local Driving License Application";
            this.panelMainTitle.ResumeLayout(false);
            this.panelMainTitle.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainTitle;
        private System.Windows.Forms.Label lblManageLocalLicense;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.PictureBox pictureBoxLocalLicense;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dataGridViewApplications;
    }
}