using System;

namespace DVLD
{
    partial class usrCtrlAddEditPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblPersonIDValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblNationalNumber = new System.Windows.Forms.Label();
            this.txtNationalNumber = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.lblSetImage = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(270, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(200, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Add New Person";
            // 
            // lblPersonID
            // 
            this.lblPersonID.Location = new System.Drawing.Point(20, 42);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(80, 15);
            this.lblPersonID.TabIndex = 1;
            this.lblPersonID.Text = "Person ID:";
            // 
            // lblPersonIDValue
            // 
            this.lblPersonIDValue.Location = new System.Drawing.Point(110, 42);
            this.lblPersonIDValue.Name = "lblPersonIDValue";
            this.lblPersonIDValue.Size = new System.Drawing.Size(100, 15);
            this.lblPersonIDValue.TabIndex = 2;
            this.lblPersonIDValue.Text = "N/A";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(20, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblFirst
            // 
            this.lblFirst.Location = new System.Drawing.Point(135, 57);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(50, 20);
            this.lblFirst.TabIndex = 4;
            this.lblFirst.Text = "First";
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecond
            // 
            this.lblSecond.Location = new System.Drawing.Point(241, 57);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(60, 20);
            this.lblSecond.TabIndex = 5;
            this.lblSecond.Text = "Second";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThird
            // 
            this.lblThird.Location = new System.Drawing.Point(340, 57);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(50, 20);
            this.lblThird.TabIndex = 6;
            this.lblThird.Text = "Third";
            this.lblThird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLast
            // 
            this.lblLast.Location = new System.Drawing.Point(429, 57);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(50, 20);
            this.lblLast.TabIndex = 7;
            this.lblLast.Text = "Last";
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(110, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 21);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(220, 80);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(100, 21);
            this.txtSecondName.TabIndex = 9;
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(330, 80);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(70, 21);
            this.txtThirdName.TabIndex = 10;
            this.txtThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(410, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 21);
            this.txtLastName.TabIndex = 11;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblNationalNumber
            // 
            this.lblNationalNumber.Location = new System.Drawing.Point(20, 130);
            this.lblNationalNumber.Name = "lblNationalNumber";
            this.lblNationalNumber.Size = new System.Drawing.Size(80, 20);
            this.lblNationalNumber.TabIndex = 12;
            this.lblNationalNumber.Text = "National No:";
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.Location = new System.Drawing.Point(110, 130);
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(150, 21);
            this.txtNationalNumber.TabIndex = 13;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(20, 170);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 20);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender:";
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(110, 170);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(60, 20);
            this.rbMale.TabIndex = 15;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.Location = new System.Drawing.Point(180, 170);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(80, 20);
            this.rbFemale.TabIndex = 16;
            this.rbFemale.Text = "Female";
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Location = new System.Drawing.Point(288, 130);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(86, 20);
            this.lblDateOfBirth.TabIndex = 17;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(380, 130);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2007, 4, 18, 22, 31, 30, 955);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1945, 4, 18, 22, 31, 30, 955);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(130, 21);
            this.dtpDateOfBirth.TabIndex = 18;
            this.dtpDateOfBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(316, 170);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(54, 20);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(380, 170);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 21);
            this.txtPhone.TabIndex = 20;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(20, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 20);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 21);
            this.txtEmail.TabIndex = 22;
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(316, 210);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(54, 20);
            this.lblCountry.TabIndex = 23;
            this.lblCountry.Text = "Country:";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Location = new System.Drawing.Point(380, 207);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(130, 23);
            this.cmbCountry.TabIndex = 24;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(20, 250);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 20);
            this.lblAddress.TabIndex = 25;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 250);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(380, 60);
            this.txtAddress.TabIndex = 26;
            // 
            // pbUserImage
            // 
            this.pbUserImage.BackColor = System.Drawing.Color.LightGray;
            this.pbUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserImage.Image = global::DVLD.Properties.Resources.DefaultMan;
            this.pbUserImage.Location = new System.Drawing.Point(530, 80);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(120, 120);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserImage.TabIndex = 27;
            this.pbUserImage.TabStop = false;
            // 
            // lblSetImage
            // 
            this.lblSetImage.Location = new System.Drawing.Point(553, 210);
            this.lblSetImage.Name = "lblSetImage";
            this.lblSetImage.Size = new System.Drawing.Size(70, 20);
            this.lblSetImage.TabIndex = 28;
            this.lblSetImage.TabStop = true;
            this.lblSetImage.Text = "Set Image";
            this.lblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSetImage_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(530, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 30);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(610, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 30);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // usrCtrlAddEditPerson
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblPersonIDValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblThird);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtThirdName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblNationalNumber);
            this.Controls.Add(this.txtNationalNumber);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.pbUserImage);
            this.Controls.Add(this.lblSetImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "usrCtrlAddEditPerson";
            this.Size = new System.Drawing.Size(688, 378);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblPersonIDValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblNationalNumber;
        private System.Windows.Forms.TextBox txtNationalNumber;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.LinkLabel lblSetImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}