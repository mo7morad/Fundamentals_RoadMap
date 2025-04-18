namespace SendDataBackToFromUsingDelgate
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
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(13, 82);
            this.btnOpenForm2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(350, 31);
            this.btnOpenForm2.TabIndex = 0;
            this.btnOpenForm2.Text = "OpenForm 2";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(456, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 26);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 269);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOpenForm2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenForm2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

