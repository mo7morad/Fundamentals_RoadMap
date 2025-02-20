namespace MyFirstWinFormsProject
{
    partial class frmChkRadioGroup
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
            this.chkReceiveEmail = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbBox1 = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.gbBox1.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkReceiveEmail
            // 
            this.chkReceiveEmail.AutoSize = true;
            this.chkReceiveEmail.Location = new System.Drawing.Point(142, 79);
            this.chkReceiveEmail.Name = "chkReceiveEmail";
            this.chkReceiveEmail.Size = new System.Drawing.Size(175, 17);
            this.chkReceiveEmail.TabIndex = 0;
            this.chkReceiveEmail.Text = "Do you want to revcieve email?";
            this.chkReceiveEmail.UseVisualStyleBackColor = true;
            this.chkReceiveEmail.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(142, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbBox1
            // 
            this.gbBox1.Controls.Add(this.rbThick);
            this.gbBox1.Controls.Add(this.rbThin);
            this.gbBox1.Location = new System.Drawing.Point(710, 48);
            this.gbBox1.Name = "gbBox1";
            this.gbBox1.Size = new System.Drawing.Size(239, 148);
            this.gbBox1.TabIndex = 8;
            this.gbBox1.TabStop = false;
            this.gbBox1.Text = "Crust";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(32, 70);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(52, 17);
            this.rbThick.TabIndex = 9;
            this.rbThick.TabStop = true;
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(32, 31);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(46, 17);
            this.rbThin.TabIndex = 8;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(442, 47);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(245, 149);
            this.gbSize.TabIndex = 9;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Pizza Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(16, 110);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 7;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(16, 76);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 6;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(16, 37);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 5;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(706, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 52);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmChkRadioGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 456);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkReceiveEmail);
            this.Name = "frmChkRadioGroup";
            this.Text = "frmChkRadioGroup";
            this.gbBox1.ResumeLayout(false);
            this.gbBox1.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkReceiveEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbBox1;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Button button3;
    }
}