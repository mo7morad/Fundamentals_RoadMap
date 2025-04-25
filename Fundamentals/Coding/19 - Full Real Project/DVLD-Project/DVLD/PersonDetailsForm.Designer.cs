namespace DVLD
{
    partial class PersonDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent(int personID)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonDetailsForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.usrCtrlPersonInfoCard = new DVLD.usrCtrlPersonInfoCard(personID);
            this.panelContainer.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.usrCtrlPersonInfoCard);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 40);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(10);
            this.panelContainer.Size = new System.Drawing.Size(1036, 303);
            this.panelContainer.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(45, 50, 80);
            this.titleBar.Controls.Add(this.titleLabel);
            this.titleBar.Controls.Add(this.closeButton);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1036, 40);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.titleLabel.Size = new System.Drawing.Size(200, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Person Details";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(996, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
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
                this.usrCtrlPersonInfoCard.Location = new System.Drawing.Point(10, 10);
                this.usrCtrlPersonInfoCard.Name = "usrCtrlPersonInfoCard";
                this.usrCtrlPersonInfoCard.NationalNo = "???";
                this.usrCtrlPersonInfoCard.PersonID = "???";
                this.usrCtrlPersonInfoCard.PersonImage = ((System.Drawing.Image)(resources.GetObject("usrCtrlPersonInfoCard.PersonImage")));
                this.usrCtrlPersonInfoCard.Phone = "???";
                this.usrCtrlPersonInfoCard.Size = new System.Drawing.Size(1016, 283);
                this.usrCtrlPersonInfoCard.TabIndex = 0;
            }
            // 
            // PersonDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(1036, 343);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Details";
            this.panelContainer.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private usrCtrlPersonInfoCard usrCtrlPersonInfoCard;
    }
}
