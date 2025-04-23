namespace DVLD
{
    partial class PersonDetailsForm
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
        private void InitializeComponent(int personID)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonDetailsForm));
            this.usrCtrlPersonInfoCard = new DVLD.usrCtrlPersonInfoCard(personID);
            this.SuspendLayout();
            // 
            // usrCtrlPersonInfoCard
            // 
            if (personID == 0)
            {

                this.usrCtrlPersonInfoCard.Address = "???";
                this.usrCtrlPersonInfoCard.Country = "???";
                this.usrCtrlPersonInfoCard.DateOfBirth = "???";
                this.usrCtrlPersonInfoCard.Dock = System.Windows.Forms.DockStyle.Fill;
                this.usrCtrlPersonInfoCard.Email = "???";
                this.usrCtrlPersonInfoCard.FullName = "???";
                this.usrCtrlPersonInfoCard.Gender = "???";
                this.usrCtrlPersonInfoCard.Location = new System.Drawing.Point(0, 0);
                this.usrCtrlPersonInfoCard.Name = "usrCtrlPersonInfoCard";
                this.usrCtrlPersonInfoCard.NationalNo = "???";
                this.usrCtrlPersonInfoCard.PersonID = "???";
                this.usrCtrlPersonInfoCard.PersonImage = ((System.Drawing.Image)(resources.GetObject("usrCtrlPersonInfoCard.PersonImage")));
                this.usrCtrlPersonInfoCard.Phone = "???";
                this.usrCtrlPersonInfoCard.Size = new System.Drawing.Size(800, 308);
                this.usrCtrlPersonInfoCard.TabIndex = 0;
            }
            // 
            // PersonDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 343);
            this.Controls.Add(this.usrCtrlPersonInfoCard);
            this.Name = "PersonDetailsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Details";
            this.ResumeLayout(false);

        }
        #endregion

        private usrCtrlPersonInfoCard usrCtrlPersonInfoCard;
    }
}