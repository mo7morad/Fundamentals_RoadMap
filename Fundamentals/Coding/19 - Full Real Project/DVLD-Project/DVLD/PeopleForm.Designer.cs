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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleForm));
            this.panelManagePeople = new System.Windows.Forms.Panel();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.panelFilterBy = new System.Windows.Forms.Panel();
            this.txtBoxFilterBy = new System.Windows.Forms.TextBox();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.toolTipAddNewPerson = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClosePeopleForm = new System.Windows.Forms.Button();
            this.pictureBoxAddPerson = new System.Windows.Forms.PictureBox();
            this.pictureBoxManagePeople = new System.Windows.Forms.PictureBox();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.panelFilterBy.SuspendLayout();
            this.contextMenuStripDataGridView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagePeople)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManagePeople
            // 
            this.panelManagePeople.Controls.Add(this.panel2);
            this.panelManagePeople.Controls.Add(this.panel1);
            this.panelManagePeople.Controls.Add(this.panelFilterBy);
            this.panelManagePeople.Controls.Add(this.lblManagePeople);
            this.panelManagePeople.Controls.Add(this.pictureBoxManagePeople);
            this.panelManagePeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManagePeople.Location = new System.Drawing.Point(0, 0);
            this.panelManagePeople.Margin = new System.Windows.Forms.Padding(4);
            this.panelManagePeople.Name = "panelManagePeople";
            this.panelManagePeople.Size = new System.Drawing.Size(1165, 522);
            this.panelManagePeople.TabIndex = 0;
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.AllowUserToAddRows = false;
            this.dataGridViewPeople.AllowUserToDeleteRows = false;
            this.dataGridViewPeople.AllowUserToOrderColumns = true;
            this.dataGridViewPeople.AllowUserToResizeColumns = false;
            this.dataGridViewPeople.AllowUserToResizeRows = false;
            this.dataGridViewPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPeople.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPeople.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewPeople.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.ReadOnly = true;
            this.dataGridViewPeople.Size = new System.Drawing.Size(1165, 348);
            this.dataGridViewPeople.TabIndex = 3;
            this.dataGridViewPeople.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPeople_CellMouseClick);
            // 
            // panelFilterBy
            // 
            this.panelFilterBy.Controls.Add(this.txtBoxFilterBy);
            this.panelFilterBy.Controls.Add(this.comboBoxFilterBy);
            this.panelFilterBy.Controls.Add(this.pictureBoxAddPerson);
            this.panelFilterBy.Controls.Add(this.lblFilterBy);
            this.panelFilterBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterBy.Location = new System.Drawing.Point(0, 134);
            this.panelFilterBy.Name = "panelFilterBy";
            this.panelFilterBy.Size = new System.Drawing.Size(1165, 40);
            this.panelFilterBy.TabIndex = 2;
            // 
            // txtBoxFilterBy
            // 
            this.txtBoxFilterBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFilterBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFilterBy.Location = new System.Drawing.Point(308, 7);
            this.txtBoxFilterBy.Name = "txtBoxFilterBy";
            this.txtBoxFilterBy.Size = new System.Drawing.Size(250, 25);
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
            this.comboBoxFilterBy.Size = new System.Drawing.Size(203, 25);
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
            // contextMenuStripDataGridView
            // 
            this.contextMenuStripDataGridView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStripDataGridView.Name = "contextMenuStripDataGridView";
            this.contextMenuStripDataGridView.Size = new System.Drawing.Size(191, 232);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewPeople);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 348);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClosePeopleForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 37);
            this.panel2.TabIndex = 4;
            // 
            // btnClosePeopleForm
            // 
            this.btnClosePeopleForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePeopleForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClosePeopleForm.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClosePeopleForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePeopleForm.Location = new System.Drawing.Point(1040, 0);
            this.btnClosePeopleForm.Name = "btnClosePeopleForm";
            this.btnClosePeopleForm.Size = new System.Drawing.Size(125, 37);
            this.btnClosePeopleForm.TabIndex = 0;
            this.btnClosePeopleForm.Text = "Close";
            this.btnClosePeopleForm.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAddPerson
            // 
            this.pictureBoxAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddPerson.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxAddPerson.Image = global::DVLD.Properties.Resources.Add_Person_72;
            this.pictureBoxAddPerson.Location = new System.Drawing.Point(1089, 0);
            this.pictureBoxAddPerson.Name = "pictureBoxAddPerson";
            this.pictureBoxAddPerson.Size = new System.Drawing.Size(76, 40);
            this.pictureBoxAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddPerson.TabIndex = 2;
            this.pictureBoxAddPerson.TabStop = false;
            this.pictureBoxAddPerson.Click += new System.EventHandler(this.pictureBoxAddPerson_Click);
            this.pictureBoxAddPerson.MouseEnter += new System.EventHandler(this.pictureBoxAddPerson_MouseEnter);
            // 
            // pictureBoxManagePeople
            // 
            this.pictureBoxManagePeople.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxManagePeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxManagePeople.Image = global::DVLD.Properties.Resources.ManagePeople;
            this.pictureBoxManagePeople.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxManagePeople.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxManagePeople.Name = "pictureBoxManagePeople";
            this.pictureBoxManagePeople.Size = new System.Drawing.Size(1165, 110);
            this.pictureBoxManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxManagePeople.TabIndex = 0;
            this.pictureBoxManagePeople.TabStop = false;
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(190, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.addNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(190, 38);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(190, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(190, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.Email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(190, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(190, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 522);
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
            this.contextMenuStripDataGridView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPerson)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.PictureBox pictureBoxAddPerson;
        private System.Windows.Forms.ToolTip toolTipAddNewPerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGridView;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClosePeopleForm;
    }
}