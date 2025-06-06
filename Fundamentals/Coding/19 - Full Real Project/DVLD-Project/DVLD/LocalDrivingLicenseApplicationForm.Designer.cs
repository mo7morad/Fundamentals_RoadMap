using BusinessLayer;
using Entities.Enums;
using System.Data;

namespace DVLD
{
    partial class LocalDrivingLicenseApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Add UI control field declarations
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.LinkLabel linkLabelApplicationInfo;
        private System.Windows.Forms.LinkLabel linkLabelPersonalInfo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePersonalInfo;
        private System.Windows.Forms.Panel panelPerson;
        private System.Windows.Forms.LinkLabel linkLabelEditPerson;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPersonInfo;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblPersonIDCaption;
        private System.Windows.Forms.Label lblPersonNameCaption;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label lblNationalNoCaption;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.Label lblGenderCaption;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmailCaption;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddressCaption;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDateOfBirthCaption;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPhoneCaption;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountryCaption;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.PictureBox pictureBoxPerson;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.TextBox txtFindValue;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.ComboBox comboBoxFindBy;
        private System.Windows.Forms.LinkLabel linkLabelAddNewPerson;
        private System.Windows.Forms.TabPage tabPageApplicationInfo;
        private System.Windows.Forms.Panel panelApplicationInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelApplicationInfo;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblApplicationIDCaption;
        private System.Windows.Forms.Label lblApplicationDateCaption;
        private System.Windows.Forms.Label lblLicenseClassCaption;
        private System.Windows.Forms.Label lblApplicationFeesCaption;
        private System.Windows.Forms.Label lblCreatedByCaption;
        private System.Windows.Forms.TextBox txtApplicationFees;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.ComboBox comboBoxLicenseClass;
        private System.Windows.Forms.DateTimePicker datePickerApplicationDate;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ErrorProvider errorProvider;

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
        private void InitializeComponent(enFormMode formMode = enFormMode.AddNew)
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTabs = new System.Windows.Forms.Panel();
            this.linkLabelApplicationInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabelPersonalInfo = new System.Windows.Forms.LinkLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePersonalInfo = new System.Windows.Forms.TabPage();
            this.panelPerson = new System.Windows.Forms.Panel();
            this.linkLabelEditPerson = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanelPersonInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblPersonIDCaption = new System.Windows.Forms.Label();
            this.lblPersonNameCaption = new System.Windows.Forms.Label();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lblNationalNoCaption = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.lblGenderCaption = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmailCaption = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddressCaption = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDateOfBirthCaption = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPhoneCaption = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountryCaption = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.pictureBoxPerson = new System.Windows.Forms.PictureBox();
            this.panelFind = new System.Windows.Forms.Panel();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.txtFindValue = new System.Windows.Forms.TextBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.comboBoxFindBy = new System.Windows.Forms.ComboBox();
            this.linkLabelAddNewPerson = new System.Windows.Forms.LinkLabel();
            this.tabPageApplicationInfo = new System.Windows.Forms.TabPage();
            this.panelApplicationInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanelApplicationInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblApplicationIDCaption = new System.Windows.Forms.Label();
            this.lblApplicationDateCaption = new System.Windows.Forms.Label();
            this.lblLicenseClassCaption = new System.Windows.Forms.Label();
            this.lblApplicationFeesCaption = new System.Windows.Forms.Label();
            this.lblCreatedByCaption = new System.Windows.Forms.Label();
            this.txtApplicationFees = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.comboBoxLicenseClass = new System.Windows.Forms.ComboBox();
            this.datePickerApplicationDate = new System.Windows.Forms.DateTimePicker();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelHeader.SuspendLayout();
            this.panelTabs.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPagePersonalInfo.SuspendLayout();
            this.panelPerson.SuspendLayout();
            this.tableLayoutPanelPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerson)).BeginInit();
            this.panelFind.SuspendLayout();
            this.tabPageApplicationInfo.SuspendLayout();
            this.panelApplicationInfo.SuspendLayout();
            this.tableLayoutPanelApplicationInfo.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(193, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(507, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "New Local Driving License Application";
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelTabs.Controls.Add(this.linkLabelApplicationInfo);
            this.panelTabs.Controls.Add(this.linkLabelPersonalInfo);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabs.Location = new System.Drawing.Point(0, 80);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(800, 40);
            this.panelTabs.TabIndex = 1;
            // 
            // linkLabelApplicationInfo
            // 
            this.linkLabelApplicationInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelApplicationInfo.AutoSize = true;
            this.linkLabelApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.linkLabelApplicationInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelApplicationInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelApplicationInfo.Location = new System.Drawing.Point(124, 10);
            this.linkLabelApplicationInfo.Name = "linkLabelApplicationInfo";
            this.linkLabelApplicationInfo.Size = new System.Drawing.Size(105, 19);
            this.linkLabelApplicationInfo.TabIndex = 1;
            this.linkLabelApplicationInfo.TabStop = true;
            this.linkLabelApplicationInfo.Text = "Application Info";
            this.linkLabelApplicationInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelApplicationInfo_LinkClicked);
            // 
            // linkLabelPersonalInfo
            // 
            this.linkLabelPersonalInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelPersonalInfo.AutoSize = true;
            this.linkLabelPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabelPersonalInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelPersonalInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelPersonalInfo.Location = new System.Drawing.Point(12, 10);
            this.linkLabelPersonalInfo.Name = "linkLabelPersonalInfo";
            this.linkLabelPersonalInfo.Size = new System.Drawing.Size(97, 19);
            this.linkLabelPersonalInfo.TabIndex = 0;
            this.linkLabelPersonalInfo.TabStop = true;
            this.linkLabelPersonalInfo.Text = "Personal Info";
            this.linkLabelPersonalInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPersonalInfo_LinkClicked);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPagePersonalInfo);
            this.tabControl.Controls.Add(this.tabPageApplicationInfo);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(0, 120);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 380);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            // 
            // tabPagePersonalInfo
            // 
            this.tabPagePersonalInfo.Controls.Add(this.panelPerson);
            this.tabPagePersonalInfo.Controls.Add(this.panelFind);
            this.tabPagePersonalInfo.Location = new System.Drawing.Point(4, 5);
            this.tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            this.tabPagePersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalInfo.Size = new System.Drawing.Size(792, 371);
            this.tabPagePersonalInfo.TabIndex = 0;
            this.tabPagePersonalInfo.Text = "Personal Info";
            this.tabPagePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // panelPerson
            // 
            this.panelPerson.BackColor = System.Drawing.Color.White;
            this.panelPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPerson.Controls.Add(this.linkLabelEditPerson);
            this.panelPerson.Controls.Add(this.tableLayoutPanelPersonInfo);
            this.panelPerson.Controls.Add(this.pictureBoxPerson);
            this.panelPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPerson.Location = new System.Drawing.Point(3, 63);
            this.panelPerson.Name = "panelPerson";
            this.panelPerson.Size = new System.Drawing.Size(786, 305);
            this.panelPerson.TabIndex = 1;
            // 
            // linkLabelEditPerson
            // 
            this.linkLabelEditPerson.AutoSize = true;
            this.linkLabelEditPerson.Location = new System.Drawing.Point(620, 10);
            this.linkLabelEditPerson.Name = "linkLabelEditPerson";
            this.linkLabelEditPerson.Size = new System.Drawing.Size(82, 13);
            this.linkLabelEditPerson.TabIndex = 2;
            this.linkLabelEditPerson.TabStop = true;
            this.linkLabelEditPerson.Text = "Edit Person Info";
            this.linkLabelEditPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEditPerson_LinkClicked);
            // 
            // tableLayoutPanelPersonInfo
            // 
            this.tableLayoutPanelPersonInfo.ColumnCount = 2;
            this.tableLayoutPanelPersonInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelPersonInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblPersonID, 1, 0);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblPersonIDCaption, 0, 0);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblPersonNameCaption, 0, 1);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblPersonName, 1, 1);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblNationalNoCaption, 0, 2);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblNationalNo, 1, 2);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblGenderCaption, 0, 3);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblGender, 1, 3);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblEmailCaption, 0, 4);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblEmail, 1, 4);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblAddressCaption, 0, 5);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblAddress, 1, 5);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblDateOfBirthCaption, 0, 6);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblDateOfBirth, 1, 6);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblPhoneCaption, 0, 7);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblPhone, 1, 7);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblCountryCaption, 0, 8);
            this.tableLayoutPanelPersonInfo.Controls.Add(this.lblCountry, 1, 8);
            this.tableLayoutPanelPersonInfo.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelPersonInfo.Name = "tableLayoutPanelPersonInfo";
            this.tableLayoutPanelPersonInfo.RowCount = 9;
            this.tableLayoutPanelPersonInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelPersonInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelPersonInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelPersonInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelPersonInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelPersonInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelPersonInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelPersonInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelPersonInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelPersonInfo.Size = new System.Drawing.Size(519, 290);
            this.tableLayoutPanelPersonInfo.TabIndex = 1;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPersonID.Location = new System.Drawing.Point(158, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(35, 15);
            this.lblPersonID.TabIndex = 1;
            this.lblPersonID.Text = "[????]";
            // 
            // lblPersonIDCaption
            // 
            this.lblPersonIDCaption.AutoSize = true;
            this.lblPersonIDCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPersonIDCaption.Location = new System.Drawing.Point(3, 0);
            this.lblPersonIDCaption.Name = "lblPersonIDCaption";
            this.lblPersonIDCaption.Size = new System.Drawing.Size(64, 15);
            this.lblPersonIDCaption.TabIndex = 0;
            this.lblPersonIDCaption.Text = "Person ID:";
            // 
            // lblPersonNameCaption
            // 
            this.lblPersonNameCaption.AutoSize = true;
            this.lblPersonNameCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPersonNameCaption.Location = new System.Drawing.Point(3, 32);
            this.lblPersonNameCaption.Name = "lblPersonNameCaption";
            this.lblPersonNameCaption.Size = new System.Drawing.Size(43, 15);
            this.lblPersonNameCaption.TabIndex = 2;
            this.lblPersonNameCaption.Text = "Name:";
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPersonName.Location = new System.Drawing.Point(158, 32);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(35, 15);
            this.lblPersonName.TabIndex = 3;
            this.lblPersonName.Text = "[????]";
            // 
            // lblNationalNoCaption
            // 
            this.lblNationalNoCaption.AutoSize = true;
            this.lblNationalNoCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNationalNoCaption.Location = new System.Drawing.Point(3, 64);
            this.lblNationalNoCaption.Name = "lblNationalNoCaption";
            this.lblNationalNoCaption.Size = new System.Drawing.Size(75, 15);
            this.lblNationalNoCaption.TabIndex = 4;
            this.lblNationalNoCaption.Text = "National No:";
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNationalNo.Location = new System.Drawing.Point(158, 64);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(35, 15);
            this.lblNationalNo.TabIndex = 5;
            this.lblNationalNo.Text = "[????]";
            // 
            // lblGenderCaption
            // 
            this.lblGenderCaption.AutoSize = true;
            this.lblGenderCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGenderCaption.Location = new System.Drawing.Point(3, 96);
            this.lblGenderCaption.Name = "lblGenderCaption";
            this.lblGenderCaption.Size = new System.Drawing.Size(52, 15);
            this.lblGenderCaption.TabIndex = 6;
            this.lblGenderCaption.Text = "Gender:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGender.Location = new System.Drawing.Point(158, 96);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(35, 15);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "[????]";
            // 
            // lblEmailCaption
            // 
            this.lblEmailCaption.AutoSize = true;
            this.lblEmailCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmailCaption.Location = new System.Drawing.Point(3, 128);
            this.lblEmailCaption.Name = "lblEmailCaption";
            this.lblEmailCaption.Size = new System.Drawing.Size(39, 15);
            this.lblEmailCaption.TabIndex = 8;
            this.lblEmailCaption.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.Location = new System.Drawing.Point(158, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 15);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "[????]";
            // 
            // lblAddressCaption
            // 
            this.lblAddressCaption.AutoSize = true;
            this.lblAddressCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddressCaption.Location = new System.Drawing.Point(3, 160);
            this.lblAddressCaption.Name = "lblAddressCaption";
            this.lblAddressCaption.Size = new System.Drawing.Size(54, 15);
            this.lblAddressCaption.TabIndex = 10;
            this.lblAddressCaption.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddress.Location = new System.Drawing.Point(158, 160);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(35, 15);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "[????]";
            // 
            // lblDateOfBirthCaption
            // 
            this.lblDateOfBirthCaption.AutoSize = true;
            this.lblDateOfBirthCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirthCaption.Location = new System.Drawing.Point(3, 192);
            this.lblDateOfBirthCaption.Name = "lblDateOfBirthCaption";
            this.lblDateOfBirthCaption.Size = new System.Drawing.Size(83, 15);
            this.lblDateOfBirthCaption.TabIndex = 12;
            this.lblDateOfBirthCaption.Text = "Date of Birth:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDateOfBirth.Location = new System.Drawing.Point(158, 192);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(35, 15);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "[????]";
            // 
            // lblPhoneCaption
            // 
            this.lblPhoneCaption.AutoSize = true;
            this.lblPhoneCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhoneCaption.Location = new System.Drawing.Point(3, 224);
            this.lblPhoneCaption.Name = "lblPhoneCaption";
            this.lblPhoneCaption.Size = new System.Drawing.Size(45, 15);
            this.lblPhoneCaption.TabIndex = 14;
            this.lblPhoneCaption.Text = "Phone:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.Location = new System.Drawing.Point(158, 224);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(35, 15);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "[????]";
            // 
            // lblCountryCaption
            // 
            this.lblCountryCaption.AutoSize = true;
            this.lblCountryCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCountryCaption.Location = new System.Drawing.Point(3, 256);
            this.lblCountryCaption.Name = "lblCountryCaption";
            this.lblCountryCaption.Size = new System.Drawing.Size(54, 15);
            this.lblCountryCaption.TabIndex = 16;
            this.lblCountryCaption.Text = "Country:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCountry.Location = new System.Drawing.Point(158, 256);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(35, 15);
            this.lblCountry.TabIndex = 17;
            this.lblCountry.Text = "[????]";
            // 
            // pictureBoxPerson
            // 
            this.pictureBoxPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPerson.Location = new System.Drawing.Point(587, 33);
            this.pictureBoxPerson.Name = "pictureBoxPerson";
            this.pictureBoxPerson.Size = new System.Drawing.Size(147, 141);
            this.pictureBoxPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPerson.TabIndex = 0;
            this.pictureBoxPerson.TabStop = false;
            // 
            // panelFind
            // 
            this.panelFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFind.Controls.Add(this.btnFindPerson);
            this.panelFind.Controls.Add(this.txtFindValue);
            this.panelFind.Controls.Add(this.lblFindBy);
            this.panelFind.Controls.Add(this.comboBoxFindBy);
            this.panelFind.Controls.Add(this.linkLabelAddNewPerson);
            this.panelFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFind.Location = new System.Drawing.Point(3, 3);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(786, 60);
            this.panelFind.TabIndex = 0;
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnFindPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindPerson.FlatAppearance.BorderSize = 0;
            this.btnFindPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPerson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFindPerson.ForeColor = System.Drawing.Color.White;
            this.btnFindPerson.Image = global::DVLD.Properties.Resources.SearchPerson;
            this.btnFindPerson.Location = new System.Drawing.Point(425, 14);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(37, 30);
            this.btnFindPerson.TabIndex = 2;
            this.btnFindPerson.UseVisualStyleBackColor = false;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // txtFindValue
            // 
            this.txtFindValue.Location = new System.Drawing.Point(234, 20);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(185, 20);
            this.txtFindValue.TabIndex = 1;
            this.txtFindValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindValue_KeyPress);
            // 
            // lblFindBy
            // 
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFindBy.Location = new System.Drawing.Point(10, 22);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(50, 15);
            this.lblFindBy.TabIndex = 1;
            this.lblFindBy.Text = "Find By:";
            // 
            // comboBoxFindBy
            // 
            this.comboBoxFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFindBy.FormattingEnabled = true;
            this.comboBoxFindBy.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.comboBoxFindBy.Location = new System.Drawing.Point(70, 19);
            this.comboBoxFindBy.Name = "comboBoxFindBy";
            this.comboBoxFindBy.Size = new System.Drawing.Size(158, 21);
            this.comboBoxFindBy.TabIndex = 0;
            this.comboBoxFindBy.SelectedIndex = 0;
            this.comboBoxFindBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFindBy_SelectedIndexChanged);
            // 
            // linkLabelAddNewPerson
            // 
            this.linkLabelAddNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAddNewPerson.AutoSize = true;
            this.linkLabelAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabelAddNewPerson.Location = new System.Drawing.Point(611, 22);
            this.linkLabelAddNewPerson.Name = "linkLabelAddNewPerson";
            this.linkLabelAddNewPerson.Size = new System.Drawing.Size(95, 15);
            this.linkLabelAddNewPerson.TabIndex = 3;
            this.linkLabelAddNewPerson.TabStop = true;
            this.linkLabelAddNewPerson.Text = "Add New Person";
            this.linkLabelAddNewPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewPerson_LinkClicked);
            // 
            // tabPageApplicationInfo
            // 
            this.tabPageApplicationInfo.Controls.Add(this.panelApplicationInfo);
            this.tabPageApplicationInfo.Location = new System.Drawing.Point(4, 5);
            this.tabPageApplicationInfo.Name = "tabPageApplicationInfo";
            this.tabPageApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApplicationInfo.Size = new System.Drawing.Size(792, 371);
            this.tabPageApplicationInfo.TabIndex = 1;
            this.tabPageApplicationInfo.Text = "Application Info";
            this.tabPageApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // panelApplicationInfo
            // 
            this.panelApplicationInfo.BackColor = System.Drawing.Color.White;
            this.panelApplicationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelApplicationInfo.Controls.Add(this.tableLayoutPanelApplicationInfo);
            this.panelApplicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelApplicationInfo.Location = new System.Drawing.Point(3, 3);
            this.panelApplicationInfo.Name = "panelApplicationInfo";
            this.panelApplicationInfo.Size = new System.Drawing.Size(786, 365);
            this.panelApplicationInfo.TabIndex = 0;
            // 
            // tableLayoutPanelApplicationInfo
            // 
            this.tableLayoutPanelApplicationInfo.ColumnCount = 2;
            this.tableLayoutPanelApplicationInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelApplicationInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelApplicationInfo.Controls.Add(this.lblApplicationID, 1, 0);
            this.tableLayoutPanelApplicationInfo.Controls.Add(this.lblApplicationIDCaption, 0, 0);
            this.tableLayoutPanelApplicationInfo.Controls.Add(this.lblApplicationDateCaption, 0, 1);
            this.tableLayoutPanelApplicationInfo.Controls.Add(this.lblLicenseClassCaption, 0, 2);
            this.tableLayoutPanelApplicationInfo.Controls.Add(this.lblApplicationFeesCaption, 0, 3);
            this.tableLayoutPanelApplicationInfo.Controls.Add(this.lblCreatedByCaption, 0, 4);
            this.tableLayoutPanelApplicationInfo.Controls.Add(this.txtApplicationFees, 1, 3);
            this.tableLayoutPanelApplicationInfo.Controls.Add(this.txtCreatedBy, 1, 4);
            this.tableLayoutPanelApplicationInfo.Controls.Add(this.comboBoxLicenseClass, 1, 2);
            this.tableLayoutPanelApplicationInfo.Controls.Add(this.datePickerApplicationDate, 1, 1);
            this.tableLayoutPanelApplicationInfo.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelApplicationInfo.Name = "tableLayoutPanelApplicationInfo";
            this.tableLayoutPanelApplicationInfo.RowCount = 5;
            this.tableLayoutPanelApplicationInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelApplicationInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelApplicationInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelApplicationInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelApplicationInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelApplicationInfo.Size = new System.Drawing.Size(766, 150);
            this.tableLayoutPanelApplicationInfo.TabIndex = 0;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblApplicationID.Location = new System.Drawing.Point(232, 0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(35, 15);
            this.lblApplicationID.TabIndex = 1;
            this.lblApplicationID.Text = "[????]";
            // 
            // lblApplicationIDCaption
            // 
            this.lblApplicationIDCaption.AutoSize = true;
            this.lblApplicationIDCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblApplicationIDCaption.Location = new System.Drawing.Point(3, 0);
            this.lblApplicationIDCaption.Name = "lblApplicationIDCaption";
            this.lblApplicationIDCaption.Size = new System.Drawing.Size(108, 15);
            this.lblApplicationIDCaption.TabIndex = 0;
            this.lblApplicationIDCaption.Text = "D.L Application ID:";
            // 
            // lblApplicationDateCaption
            // 
            this.lblApplicationDateCaption.AutoSize = true;
            this.lblApplicationDateCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblApplicationDateCaption.Location = new System.Drawing.Point(3, 30);
            this.lblApplicationDateCaption.Name = "lblApplicationDateCaption";
            this.lblApplicationDateCaption.Size = new System.Drawing.Size(102, 15);
            this.lblApplicationDateCaption.TabIndex = 2;
            this.lblApplicationDateCaption.Text = "Application Date:";
            // 
            // lblLicenseClassCaption
            // 
            this.lblLicenseClassCaption.AutoSize = true;
            this.lblLicenseClassCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicenseClassCaption.Location = new System.Drawing.Point(3, 60);
            this.lblLicenseClassCaption.Name = "lblLicenseClassCaption";
            this.lblLicenseClassCaption.Size = new System.Drawing.Size(80, 15);
            this.lblLicenseClassCaption.TabIndex = 3;
            this.lblLicenseClassCaption.Text = "License Class:";
            // 
            // lblApplicationFeesCaption
            // 
            this.lblApplicationFeesCaption.AutoSize = true;
            this.lblApplicationFeesCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblApplicationFeesCaption.Location = new System.Drawing.Point(3, 90);
            this.lblApplicationFeesCaption.Name = "lblApplicationFeesCaption";
            this.lblApplicationFeesCaption.Size = new System.Drawing.Size(100, 15);
            this.lblApplicationFeesCaption.TabIndex = 4;
            this.lblApplicationFeesCaption.Text = "Application Fees:";
            // 
            // lblCreatedByCaption
            // 
            this.lblCreatedByCaption.AutoSize = true;
            this.lblCreatedByCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCreatedByCaption.Location = new System.Drawing.Point(3, 120);
            this.lblCreatedByCaption.Name = "lblCreatedByCaption";
            this.lblCreatedByCaption.Size = new System.Drawing.Size(71, 15);
            this.lblCreatedByCaption.TabIndex = 5;
            this.lblCreatedByCaption.Text = "Created By:";
            // 
            // txtApplicationFees
            // 
            this.txtApplicationFees.Enabled = false;
            this.txtApplicationFees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApplicationFees.Location = new System.Drawing.Point(232, 93);
            this.txtApplicationFees.Name = "txtApplicationFees";
            this.txtApplicationFees.Size = new System.Drawing.Size(100, 23);
            this.txtApplicationFees.TabIndex = 2;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCreatedBy.Location = new System.Drawing.Point(232, 123);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.ReadOnly = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(200, 23);
            this.txtCreatedBy.TabIndex = 3;
            this.txtCreatedBy.Text = clsCurrentSession.LoggedInUserName;
            // 
            // comboBoxLicenseClass
            // 
            this.comboBoxLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLicenseClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxLicenseClass.FormattingEnabled = true;
            this.comboBoxLicenseClass.Location = new System.Drawing.Point(232, 63);
            this.comboBoxLicenseClass.Name = "comboBoxLicenseClass";
            this.comboBoxLicenseClass.Size = new System.Drawing.Size(396, 23);
            this.comboBoxLicenseClass.TabIndex = 1;
            this.comboBoxLicenseClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxLicenseClass_SelectedIndexChanged);
            // 
            // datePickerApplicationDate
            // 
            this.datePickerApplicationDate.Enabled = false;
            this.datePickerApplicationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePickerApplicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerApplicationDate.Location = new System.Drawing.Point(232, 33);
            this.datePickerApplicationDate.Name = "datePickerApplicationDate";
            this.datePickerApplicationDate.Size = new System.Drawing.Size(200, 23);
            this.datePickerApplicationDate.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelFooter.Controls.Add(this.btnClose);
            this.panelFooter.Controls.Add(this.btnSave);
            this.panelFooter.Controls.Add(this.btnNext);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 500);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 50);
            this.panelFooter.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(713, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(631, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(549, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 26);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // LocalDrivingLicenseApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelTabs);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LocalDrivingLicenseApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            if (formMode == enFormMode.AddNew)
                this.Text = "New Local Driving License Application";
            else
                this.Text = "Update Local Driving License Application";
            this.Load += new System.EventHandler(this.LocalDrivingLicenseApplicationForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTabs.ResumeLayout(false);
            this.panelTabs.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPagePersonalInfo.ResumeLayout(false);
            this.panelPerson.ResumeLayout(false);
            this.panelPerson.PerformLayout();
            this.tableLayoutPanelPersonInfo.ResumeLayout(false);
            this.tableLayoutPanelPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerson)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.tabPageApplicationInfo.ResumeLayout(false);
            this.panelApplicationInfo.ResumeLayout(false);
            this.tableLayoutPanelApplicationInfo.ResumeLayout(false);
            this.tableLayoutPanelApplicationInfo.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}