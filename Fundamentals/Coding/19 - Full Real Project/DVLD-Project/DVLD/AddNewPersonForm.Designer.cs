namespace DVLD
{
    partial class addNewPersonForm
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
            this.usrCtrlAddNewPerson = new DVLD.usrCtrlAddEditPerson();
            this.SuspendLayout();
            // 
            // usrCtrlAddNewPerson
            // 
            this.usrCtrlAddNewPerson.Address = "";
            this.usrCtrlAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.usrCtrlAddNewPerson.Country = "";
            this.usrCtrlAddNewPerson.DateOfBirth = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.usrCtrlAddNewPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrCtrlAddNewPerson.Email = "";
            this.usrCtrlAddNewPerson.FirstName = "";
            this.usrCtrlAddNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.usrCtrlAddNewPerson.Gender = 'M';
            this.usrCtrlAddNewPerson.LastName = "";
            this.usrCtrlAddNewPerson.Location = new System.Drawing.Point(0, 0);
            this.usrCtrlAddNewPerson.Name = "usrCtrlAddNewPerson";
            this.usrCtrlAddNewPerson.NationalNumber = "";
            this.usrCtrlAddNewPerson.PersonID = "";
            this.usrCtrlAddNewPerson.Phone = "";
            this.usrCtrlAddNewPerson.SecondName = "";
            this.usrCtrlAddNewPerson.Size = new System.Drawing.Size(697, 385);
            this.usrCtrlAddNewPerson.TabIndex = 0;
            this.usrCtrlAddNewPerson.ThirdName = "";
            // 
            // addNewPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 385);
            this.Controls.Add(this.usrCtrlAddNewPerson);
            this.Name = "addNewPersonForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Person";
            this.ResumeLayout(false);

        }

        #endregion

        private usrCtrlAddEditPerson usrCtrlAddNewPerson;
    }
}