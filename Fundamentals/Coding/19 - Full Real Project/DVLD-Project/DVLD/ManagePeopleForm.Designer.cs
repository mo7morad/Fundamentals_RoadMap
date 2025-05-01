using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    partial class ManagePeopleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePeopleForm));
            this.panelManagePeople = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClosePeopleForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.panelFilterBy = new System.Windows.Forms.Panel();
            this.txtBoxFilterBy = new System.Windows.Forms.TextBox();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.pictureBoxAddPerson = new System.Windows.Forms.PictureBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.pictureBoxManagePeople = new System.Windows.Forms.PictureBox();
            this.toolTipAddNewPerson = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelManagePeople.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.panelFilterBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPerson)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagePeople)).BeginInit();
            this.contextMenuStripDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManagePeople
            // 
            this.panelManagePeople.BackColor = System.Drawing.Color.White;
            this.panelManagePeople.Controls.Add(this.panel2);
            this.panelManagePeople.Controls.Add(this.panel1);
            this.panelManagePeople.Controls.Add(this.panelFilterBy);
            this.panelManagePeople.Controls.Add(this.headerPanel);
            this.panelManagePeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManagePeople.Location = new System.Drawing.Point(0, 0);
            this.panelManagePeople.Margin = new System.Windows.Forms.Padding(4);
            this.panelManagePeople.Name = "panelManagePeople";
            this.panelManagePeople.Size = new System.Drawing.Size(1278, 522);
            this.panelManagePeople.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.lblRecordsCount);
            this.panel2.Controls.Add(this.btnClosePeopleForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 37);
            this.panel2.TabIndex = 4;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblRecordsCount.Location = new System.Drawing.Point(12, 9);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(124, 19);
            this.lblRecordsCount.TabIndex = 1;
            this.lblRecordsCount.Text = "Total Records: #0";
            // 
            // btnClosePeopleForm
            // 
            this.btnClosePeopleForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClosePeopleForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePeopleForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClosePeopleForm.FlatAppearance.BorderSize = 0;
            this.btnClosePeopleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePeopleForm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePeopleForm.ForeColor = System.Drawing.Color.White;
            this.btnClosePeopleForm.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClosePeopleForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePeopleForm.Location = new System.Drawing.Point(1153, 0);
            this.btnClosePeopleForm.Name = "btnClosePeopleForm";
            this.btnClosePeopleForm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClosePeopleForm.Size = new System.Drawing.Size(125, 37);
            this.btnClosePeopleForm.TabIndex = 0;
            this.btnClosePeopleForm.Text = "  Close";
            this.btnClosePeopleForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClosePeopleForm.UseVisualStyleBackColor = false;
            this.btnClosePeopleForm.Click += new System.EventHandler(this.btnClosePeopleForm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewPeople);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(1278, 348);
            this.panel1.TabIndex = 3;
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
            this.dataGridViewPeople.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPeople.ColumnHeadersHeight = 35;
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPeople.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPeople.EnableHeadersVisualStyles = false;
            this.dataGridViewPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridViewPeople.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPeople.RowHeadersVisible = false;
            this.dataGridViewPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPeople.Size = new System.Drawing.Size(1248, 318);
            this.dataGridViewPeople.TabIndex = 3;
            this.dataGridViewPeople.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeople_CellDoubleClick);
            this.dataGridViewPeople.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPeople_CellMouseClick);
            // 
            // panelFilterBy
            // 
            this.panelFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelFilterBy.Controls.Add(this.txtBoxFilterBy);
            this.panelFilterBy.Controls.Add(this.comboBoxFilterBy);
            this.panelFilterBy.Controls.Add(this.pictureBoxAddPerson);
            this.panelFilterBy.Controls.Add(this.lblFilterBy);
            this.panelFilterBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterBy.Location = new System.Drawing.Point(0, 134);
            this.panelFilterBy.Name = "panelFilterBy";
            this.panelFilterBy.Size = new System.Drawing.Size(1278, 40);
            this.panelFilterBy.TabIndex = 2;
            // 
            // txtBoxFilterBy
            // 
            this.txtBoxFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFilterBy.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFilterBy.Location = new System.Drawing.Point(221, 10);
            this.txtBoxFilterBy.Name = "txtBoxFilterBy";
            this.txtBoxFilterBy.Size = new System.Drawing.Size(171, 19);
            this.txtBoxFilterBy.TabIndex = 1;
            this.txtBoxFilterBy.Visible = false;
            this.txtBoxFilterBy.TextChanged += new System.EventHandler(this.txtBoxFilterBy_TextChanged);
            this.txtBoxFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFilterBy_KeyPress);
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.BackColor = System.Drawing.Color.White;
            this.comboBoxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Location = new System.Drawing.Point(82, 8);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(132, 25);
            this.comboBoxFilterBy.TabIndex = 0;
            this.comboBoxFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterBy_SelectedIndexChanged);
            // 
            // pictureBoxAddPerson
            // 
            this.pictureBoxAddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.pictureBoxAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddPerson.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxAddPerson.Image = global::DVLD.Properties.Resources.Add_Person_72;
            this.pictureBoxAddPerson.Location = new System.Drawing.Point(1202, 0);
            this.pictureBoxAddPerson.Name = "pictureBoxAddPerson";
            this.pictureBoxAddPerson.Padding = new System.Windows.Forms.Padding(7);
            this.pictureBoxAddPerson.Size = new System.Drawing.Size(76, 40);
            this.pictureBoxAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddPerson.TabIndex = 2;
            this.pictureBoxAddPerson.TabStop = false;
            this.pictureBoxAddPerson.Click += new System.EventHandler(this.pictureBoxAddPerson_Click);
            this.pictureBoxAddPerson.MouseEnter += new System.EventHandler(this.pictureBoxAddPerson_MouseEnter);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFilterBy.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblFilterBy.Location = new System.Drawing.Point(0, 0);
            this.lblFilterBy.Margin = new System.Windows.Forms.Padding(10);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblFilterBy.Size = new System.Drawing.Size(78, 29);
            this.lblFilterBy.TabIndex = 0;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.lblManagePeople);
            this.headerPanel.Controls.Add(this.pictureBoxManagePeople);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1278, 134);
            this.headerPanel.TabIndex = 5;
            // 
            // lblManagePeople
            // 
            this.lblManagePeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManagePeople.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblManagePeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.lblManagePeople.Location = new System.Drawing.Point(0, 100);
            this.lblManagePeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagePeople.Name = "lblManagePeople";
            this.lblManagePeople.Size = new System.Drawing.Size(1278, 34);
            this.lblManagePeople.TabIndex = 1;
            this.lblManagePeople.Text = "Manage People";
            this.lblManagePeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxManagePeople
            // 
            this.pictureBoxManagePeople.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxManagePeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxManagePeople.Image = global::DVLD.Properties.Resources.ManagePeople;
            this.pictureBoxManagePeople.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxManagePeople.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxManagePeople.Name = "pictureBoxManagePeople";
            this.pictureBoxManagePeople.Size = new System.Drawing.Size(1278, 100);
            this.pictureBoxManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxManagePeople.TabIndex = 0;
            this.pictureBoxManagePeople.TabStop = false;
            // 
            // toolTipAddNewPerson
            // 
            this.toolTipAddNewPerson.AutoPopDelay = 5000;
            this.toolTipAddNewPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(170)))), ((int)(((byte)(60)))));
            this.toolTipAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.toolTipAddNewPerson.InitialDelay = 500;
            this.toolTipAddNewPerson.ReshowDelay = 100;
            // 
            // contextMenuStripDataGridView
            // 
            this.contextMenuStripDataGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contextMenuStripDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.contextMenuStripDataGridView.Name = "contextMenuStripDataGridView";
            this.contextMenuStripDataGridView.Size = new System.Drawing.Size(196, 244);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.addNewPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.Email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(195, 38);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // ManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 522);
            this.Controls.Add(this.panelManagePeople);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagePeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.panelManagePeople.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.panelFilterBy.ResumeLayout(false);
            this.panelFilterBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddPerson)).EndInit();
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagePeople)).EndInit();
            this.contextMenuStripDataGridView.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBoxAddPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Panel headerPanel;
    }
}
