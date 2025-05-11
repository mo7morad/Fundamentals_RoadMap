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
            this.pictureBoxLocalLicense = new System.Windows.Forms.PictureBox();
            this.lblManageLocalLicense = new System.Windows.Forms.Label();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewApplications = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.panelMainTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalLicense)).BeginInit();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainTitle
            // 
            this.panelMainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMainTitle.Controls.Add(this.pictureBoxLocalLicense);
            this.panelMainTitle.Controls.Add(this.lblManageLocalLicense);
            this.panelMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMainTitle.Name = "panelMainTitle";
            this.panelMainTitle.Size = new System.Drawing.Size(880, 147);
            this.panelMainTitle.TabIndex = 0;
            // 
            // pictureBoxLocalLicense
            // 
            this.pictureBoxLocalLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLocalLicense.Image = global::DVLD.Properties.Resources.Manage_Applications_641;
            this.pictureBoxLocalLicense.Location = new System.Drawing.Point(396, 12);
            this.pictureBoxLocalLicense.Name = "pictureBoxLocalLicense";
            this.pictureBoxLocalLicense.Size = new System.Drawing.Size(150, 90);
            this.pictureBoxLocalLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLocalLicense.TabIndex = 1;
            this.pictureBoxLocalLicense.TabStop = false;
            // 
            // lblManageLocalLicense
            // 
            this.lblManageLocalLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblManageLocalLicense.AutoSize = true;
            this.lblManageLocalLicense.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageLocalLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageLocalLicense.Location = new System.Drawing.Point(299, 105);
            this.lblManageLocalLicense.Name = "lblManageLocalLicense";
            this.lblManageLocalLicense.Size = new System.Drawing.Size(335, 30);
            this.lblManageLocalLicense.TabIndex = 0;
            this.lblManageLocalLicense.Text = "Local Driving License Applications";
            this.lblManageLocalLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewApplications);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 147);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Padding = new System.Windows.Forms.Padding(10);
            this.panelDataGridView.Size = new System.Drawing.Size(880, 268);
            this.panelDataGridView.TabIndex = 1;
            // 
            // dataGridViewApplications
            // 
            this.dataGridViewApplications.AllowUserToAddRows = false;
            this.dataGridViewApplications.AllowUserToDeleteRows = false;
            this.dataGridViewApplications.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewApplications.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewApplications.MultiSelect = false;
            this.dataGridViewApplications.Name = "dataGridViewApplications";
            this.dataGridViewApplications.ReadOnly = true;
            this.dataGridViewApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewApplications.Size = new System.Drawing.Size(860, 248);
            this.dataGridViewApplications.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Controls.Add(this.lblRecords);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 415);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(880, 49);
            this.panelFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(775, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecords.Location = new System.Drawing.Point(12, 19);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(91, 21);
            this.lblRecords.TabIndex = 0;
            this.lblRecords.Text = "# Records: ";
            // 
            // ManageLocalDrivingLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 464);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelMainTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ManageLocalDrivingLicenseApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Local Driving License Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageLocalDrivingLicenseApplicationForm_Load);
            this.Resize += new System.EventHandler(this.ManageLocalDrivingLicenseApplicationForm_Resize);
            this.panelMainTitle.ResumeLayout(false);
            this.panelMainTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalLicense)).EndInit();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainTitle;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblManageLocalLicense;
        private System.Windows.Forms.PictureBox pictureBoxLocalLicense;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewApplications;
    }
}