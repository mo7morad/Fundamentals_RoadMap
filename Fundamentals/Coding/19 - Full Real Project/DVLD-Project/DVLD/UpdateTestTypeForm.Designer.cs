namespace DVLD
{
    partial class UpdateTestTypeForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblApplicationTypeID = new System.Windows.Forms.Label();
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBoxDescription = new System.Windows.Forms.PictureBox();
            this.pictureBoxFees = new System.Windows.Forms.PictureBox();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(152, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update Test Type";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblID.Location = new System.Drawing.Point(12, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblApplicationTypeID
            // 
            this.lblApplicationTypeID.AutoSize = true;
            this.lblApplicationTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApplicationTypeID.Location = new System.Drawing.Point(45, 60);
            this.lblApplicationTypeID.Name = "lblApplicationTypeID";
            this.lblApplicationTypeID.Size = new System.Drawing.Size(15, 16);
            this.lblApplicationTypeID.TabIndex = 2;
            this.lblApplicationTypeID.Text = "?";
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.AutoSize = true;
            this.lblApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApplicationTitle.Location = new System.Drawing.Point(12, 90);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(42, 16);
            this.lblApplicationTitle.TabIndex = 3;
            this.lblApplicationTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTitle.Location = new System.Drawing.Point(136, 84);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(296, 22);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFees.Location = new System.Drawing.Point(12, 163);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(46, 16);
            this.lblFees.TabIndex = 5;
            this.lblFees.Text = "Fees:";
            // 
            // txtFees
            // 
            this.txtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFees.Location = new System.Drawing.Point(136, 157);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(296, 22);
            this.txtFees.TabIndex = 1;
            this.txtFees.TextChanged += new System.EventHandler(this.txtFees_TextChanged);
            this.txtFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFees_KeyPress);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDescription.Location = new System.Drawing.Point(136, 124);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(296, 22);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(12, 124);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 16);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(243, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBoxDescription
            // 
            this.pictureBoxDescription.Image = global::DVLD.Properties.Resources.ApplicationTitle1;
            this.pictureBoxDescription.Location = new System.Drawing.Point(108, 124);
            this.pictureBoxDescription.Name = "pictureBoxDescription";
            this.pictureBoxDescription.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDescription.TabIndex = 12;
            this.pictureBoxDescription.TabStop = false;
            // 
            // pictureBoxFees
            // 
            this.pictureBoxFees.Image = global::DVLD.Properties.Resources.money_32;
            this.pictureBoxFees.Location = new System.Drawing.Point(108, 157);
            this.pictureBoxFees.Name = "pictureBoxFees";
            this.pictureBoxFees.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFees.TabIndex = 9;
            this.pictureBoxFees.TabStop = false;
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.Image = global::DVLD.Properties.Resources.edit_32;
            this.pictureBoxTitle.Location = new System.Drawing.Point(108, 84);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitle.TabIndex = 9;
            this.pictureBoxTitle.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(348, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UpdateTestTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(452, 258);
            this.Controls.Add(this.pictureBoxDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureBoxFees);
            this.Controls.Add(this.pictureBoxTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblApplicationTitle);
            this.Controls.Add(this.lblApplicationTypeID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateTestTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Application Type";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblApplicationTypeID;
        private System.Windows.Forms.Label lblApplicationTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.PictureBox pictureBoxFees;
        private System.Windows.Forms.PictureBox pictureBoxDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}
