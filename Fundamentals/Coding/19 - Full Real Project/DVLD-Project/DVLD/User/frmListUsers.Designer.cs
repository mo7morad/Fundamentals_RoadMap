namespace DVLD.User
{
    partial class frmListUsers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(376, 212);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 39);
            this.lblTitle.TabIndex = 100;
            this.lblTitle.Text = "Manage Users";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Location = new System.Drawing.Point(152, 690);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(27, 20);
            this.lblRecordsCount.TabIndex = 98;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 690);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "# Records:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(133, 270);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(210, 28);
            this.cbFilterBy.TabIndex = 96;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(350, 270);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(256, 26);
            this.txtFilterValue.TabIndex = 95;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Filter By:";
             // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // cmsUsers
            // 
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.ChangePasswordtoolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsUsers.Name = "contextMenuStrip1";
            this.cmsUsers.Size = new System.Drawing.Size(197, 304);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::DVLD.Properties.Resources.Add_New_User_32;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 38);
            this.toolStripMenuItem1.Text = "Add &New User";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ChangePasswordtoolStripMenuItem
            // 
            this.ChangePasswordtoolStripMenuItem.Image = global::DVLD.Properties.Resources.Password_32;
            this.ChangePasswordtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangePasswordtoolStripMenuItem.Name = "ChangePasswordtoolStripMenuItem";
            this.ChangePasswordtoolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.ChangePasswordtoolStripMenuItem.Text = "Change &Password";
            this.ChangePasswordtoolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordtoolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.sendEmailToolStripMenuItem.Text = "Send E&mail";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone &Call";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmsUsers;
            this.dgvUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsers.Location = new System.Drawing.Point(48, 309);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(895, 371);
            this.dgvUsers.TabIndex = 93;
            this.dgvUsers.TabStop = false;
            this.dgvUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentDoubleClick);
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(350, 270);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(121, 28);
            this.cbIsActive.TabIndex = 103;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(808, 690);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 102;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = global::DVLD.Properties.Resources.Add_New_User_72;
            this.btnAddUser.Location = new System.Drawing.Point(855, 229);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(88, 69);
            this.btnAddUser.TabIndex = 101;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.Users_2_400;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(386, 14);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(220, 189);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 99;
            this.pbPersonImage.TabStop = false;
            // 
            // frmListUsers
            // 
            this.AcceptButton = this.btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(974, 750);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            this.cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordtoolStripMenuItem;
        private System.Windows.Forms.ComboBox cbIsActive;
    }
}