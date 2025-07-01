namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.myCustomTextBox1 = new WindowsFormsApp1.MyCustomTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myCustomTextBox1
            // 
            this.myCustomTextBox1.InputType = WindowsFormsApp1.MyCustomTextBox.InputTypeEnum.NumberInput;
            this.myCustomTextBox1.IsRequired = true;
            this.myCustomTextBox1.Location = new System.Drawing.Point(118, 56);
            this.myCustomTextBox1.Name = "myCustomTextBox1";
            this.myCustomTextBox1.Size = new System.Drawing.Size(100, 20);
            this.myCustomTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myCustomTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCustomTextBox myCustomTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

