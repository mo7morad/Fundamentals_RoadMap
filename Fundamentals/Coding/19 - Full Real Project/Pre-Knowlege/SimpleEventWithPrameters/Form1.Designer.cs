namespace SimpleEventWithPrameters
{
    partial class Form1
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
            this.myUserControl1 = new SimpleEventWithPrameters.MyUserControl();
            this.SuspendLayout();
            // 
            // myUserControl1
            // 
            this.myUserControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.myUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myUserControl1.Location = new System.Drawing.Point(23, 34);
            this.myUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myUserControl1.Name = "myUserControl1";
            this.myUserControl1.Size = new System.Drawing.Size(505, 162);
            this.myUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 490);
            this.Controls.Add(this.myUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyUserControl myUserControl1;
    }
}

