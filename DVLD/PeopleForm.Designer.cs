namespace DVLD
{
    partial class PeopleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleForm));
            this.panelManagePeople = new System.Windows.Forms.Panel();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilterBy = new System.Windows.Forms.Panel();
            this.txtBoxFilterBy = new System.Windows.Forms.TextBox();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.pictureBoxManagePeople = new System.Windows.Forms.PictureBox();
            this.panelManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.panelFilterBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagePeople)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManagePeople
            // 
            this.panelManagePeople.Controls.Add(this.dataGridViewPeople);
            this.panelManagePeople.Controls.Add(this.panelFilterBy);
            this.panelManagePeople.Controls.Add(this.lblManagePeople);
            this.panelManagePeople.Controls.Add(this.pictureBoxManagePeople);
            this.panelManagePeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManagePeople.Location = new System.Drawing.Point(0, 0);
            this.panelManagePeople.Margin = new System.Windows.Forms.Padding(4);
            this.panelManagePeople.Name = "panelManagePeople";
            this.panelManagePeople.Size = new System.Drawing.Size(1275, 508);
            this.panelManagePeople.TabIndex = 0;
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.AllowUserToAddRows = false;
            this.dataGridViewPeople.AllowUserToDeleteRows = false;
            this.dataGridViewPeople.AllowUserToOrderColumns = true;
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.Gender,
            this.DateOfBirth,
            this.Nationality,
            this.Phone,
            this.Email,
            this.NationalNumber,
            this.FirstName,
            this.SecondName,
            this.ThirdName,
            this.LastName});
            this.dataGridViewPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPeople.Location = new System.Drawing.Point(0, 174);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.ReadOnly = true;
            this.dataGridViewPeople.Size = new System.Drawing.Size(1275, 334);
            this.dataGridViewPeople.TabIndex = 3;
            // 
            // PersonID
            // 
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Nationality
            // 
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // NationalNumber
            // 
            this.NationalNumber.FillWeight = 140F;
            this.NationalNumber.HeaderText = "National Number";
            this.NationalNumber.Name = "NationalNumber";
            this.NationalNumber.ReadOnly = true;
            this.NationalNumber.Width = 140;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // SecondName
            // 
            this.SecondName.FillWeight = 135F;
            this.SecondName.HeaderText = "Second Name";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            this.SecondName.Width = 135;
            // 
            // ThirdName
            // 
            this.ThirdName.FillWeight = 130F;
            this.ThirdName.HeaderText = "Third Name";
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.ReadOnly = true;
            this.ThirdName.Width = 130;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // panelFilterBy
            // 
            this.panelFilterBy.Controls.Add(this.txtBoxFilterBy);
            this.panelFilterBy.Controls.Add(this.comboBoxFilterBy);
            this.panelFilterBy.Controls.Add(this.lblFilterBy);
            this.panelFilterBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterBy.Location = new System.Drawing.Point(0, 134);
            this.panelFilterBy.Name = "panelFilterBy";
            this.panelFilterBy.Size = new System.Drawing.Size(1275, 40);
            this.panelFilterBy.TabIndex = 2;
            // 
            // txtBoxFilterBy
            // 
            this.txtBoxFilterBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFilterBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFilterBy.Location = new System.Drawing.Point(222, 7);
            this.txtBoxFilterBy.Name = "txtBoxFilterBy";
            this.txtBoxFilterBy.Size = new System.Drawing.Size(161, 25);
            this.txtBoxFilterBy.TabIndex = 1;
            this.txtBoxFilterBy.Visible = false;
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National Number",
            "First Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.comboBoxFilterBy.Location = new System.Drawing.Point(85, 7);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(131, 25);
            this.comboBoxFilterBy.TabIndex = 0;
            this.comboBoxFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterBy_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(3, 7);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(76, 21);
            this.lblFilterBy.TabIndex = 0;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.AutoSize = true;
            this.lblManagePeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblManagePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagePeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManagePeople.Location = new System.Drawing.Point(0, 110);
            this.lblManagePeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.Size = new System.Drawing.Size(157, 24);
            this.lblManagePeople.TabIndex = 1;
            this.lblManagePeople.Text = "Manage People";
            // 
            // pictureBoxManagePeople
            // 
            this.pictureBoxManagePeople.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxManagePeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxManagePeople.Image = global::DVLD.Properties.Resources.ManagePeople;
            this.pictureBoxManagePeople.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxManagePeople.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxManagePeople.Name = "pictureBoxManagePeople";
            this.pictureBoxManagePeople.Size = new System.Drawing.Size(1275, 110);
            this.pictureBoxManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxManagePeople.TabIndex = 0;
            this.pictureBoxManagePeople.TabStop = false;
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 508);
            this.Controls.Add(this.panelManagePeople);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.panelManagePeople.ResumeLayout(false);
            this.panelManagePeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.panelFilterBy.ResumeLayout(false);
            this.panelFilterBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagePeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManagePeople;
        private System.Windows.Forms.PictureBox pictureBoxManagePeople;
        private System.Windows.Forms.Label lblManagePeople;
        private System.Windows.Forms.Panel panelFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox comboBoxFilterBy;
        private System.Windows.Forms.TextBox txtBoxFilterBy;
        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    }
}