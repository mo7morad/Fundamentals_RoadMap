namespace MyFirstUserControlProject
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
            this.ctrlSompleCalc1 = new MyFirstUserControlProject.ctrlSimpleCalc();
            this.ctrlSompleCalc2 = new MyFirstUserControlProject.ctrlSimpleCalc();
            this.ctrlSompleCalc3 = new MyFirstUserControlProject.ctrlSimpleCalc();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlSompleCalc1
            // 
            this.ctrlSompleCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSompleCalc1.Location = new System.Drawing.Point(13, 32);
            this.ctrlSompleCalc1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSompleCalc1.Name = "ctrlSompleCalc1";
            this.ctrlSompleCalc1.Size = new System.Drawing.Size(275, 219);
            this.ctrlSompleCalc1.TabIndex = 0;
            // 
            // ctrlSompleCalc2
            // 
            this.ctrlSompleCalc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSompleCalc2.Location = new System.Drawing.Point(342, 32);
            this.ctrlSompleCalc2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSompleCalc2.Name = "ctrlSompleCalc2";
            this.ctrlSompleCalc2.Size = new System.Drawing.Size(275, 219);
            this.ctrlSompleCalc2.TabIndex = 4;
            // 
            // ctrlSompleCalc3
            // 
            this.ctrlSompleCalc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSompleCalc3.Location = new System.Drawing.Point(722, 32);
            this.ctrlSompleCalc3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSompleCalc3.Name = "ctrlSompleCalc3";
            this.ctrlSompleCalc3.Size = new System.Drawing.Size(275, 219);
            this.ctrlSompleCalc3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 483);
            this.Controls.Add(this.ctrlSompleCalc3);
            this.Controls.Add(this.ctrlSompleCalc2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlSompleCalc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSimpleCalc ctrlSompleCalc1;
        private System.Windows.Forms.Button button1;
        private ctrlSimpleCalc ctrlSompleCalc2;
        private ctrlSimpleCalc ctrlSompleCalc3;
    }
}

