namespace MyFirstWinFormsProject
{
    partial class frmDialogs
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChangBackColor = new System.Windows.Forms.Button();
            this.btnChangeForeColor = new System.Windows.Forms.Button();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFileDialogMulti = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolderBrowsing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "This is a text";
            // 
            // btnChangBackColor
            // 
            this.btnChangBackColor.Location = new System.Drawing.Point(72, 269);
            this.btnChangBackColor.Name = "btnChangBackColor";
            this.btnChangBackColor.Size = new System.Drawing.Size(198, 49);
            this.btnChangBackColor.TabIndex = 1;
            this.btnChangBackColor.Text = "Change Back Color";
            this.btnChangBackColor.UseVisualStyleBackColor = true;
            this.btnChangBackColor.Click += new System.EventHandler(this.btnChangBackColor_Click);
            // 
            // btnChangeForeColor
            // 
            this.btnChangeForeColor.Location = new System.Drawing.Point(276, 269);
            this.btnChangeForeColor.Name = "btnChangeForeColor";
            this.btnChangeForeColor.Size = new System.Drawing.Size(198, 49);
            this.btnChangeForeColor.TabIndex = 2;
            this.btnChangeForeColor.Text = "Change Fore Color";
            this.btnChangeForeColor.UseVisualStyleBackColor = true;
            this.btnChangeForeColor.Click += new System.EventHandler(this.btnChangeForeColor_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(72, 334);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(198, 49);
            this.btnChangeFont.TabIndex = 3;
            this.btnChangeFont.Text = "Change Font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(72, 401);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(198, 49);
            this.btnSaveFileDialog.TabIndex = 4;
            this.btnSaveFileDialog.Text = "Save File Dialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(276, 401);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(198, 49);
            this.btnOpenFileDialog.TabIndex = 5;
            this.btnOpenFileDialog.Text = "Open File Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFileDialogMulti
            // 
            this.btnOpenFileDialogMulti.Location = new System.Drawing.Point(480, 401);
            this.btnOpenFileDialogMulti.Name = "btnOpenFileDialogMulti";
            this.btnOpenFileDialogMulti.Size = new System.Drawing.Size(277, 49);
            this.btnOpenFileDialogMulti.TabIndex = 6;
            this.btnOpenFileDialogMulti.Text = "Open File Dialog Multi Select";
            this.btnOpenFileDialogMulti.UseVisualStyleBackColor = true;
            this.btnOpenFileDialogMulti.Click += new System.EventHandler(this.btnOpenFileDialogMulti_Click);
            // 
            // btnFolderBrowsing
            // 
            this.btnFolderBrowsing.Location = new System.Drawing.Point(72, 477);
            this.btnFolderBrowsing.Name = "btnFolderBrowsing";
            this.btnFolderBrowsing.Size = new System.Drawing.Size(223, 49);
            this.btnFolderBrowsing.TabIndex = 7;
            this.btnFolderBrowsing.Text = "Folder Browsing Dialog";
            this.btnFolderBrowsing.UseVisualStyleBackColor = true;
            this.btnFolderBrowsing.Click += new System.EventHandler(this.btnFolderBrowsing_Click);
            // 
            // frmDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 586);
            this.Controls.Add(this.btnFolderBrowsing);
            this.Controls.Add(this.btnOpenFileDialogMulti);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.btnChangeForeColor);
            this.Controls.Add(this.btnChangBackColor);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDialogs";
            this.Text = "frmColorDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnChangBackColor;
        private System.Windows.Forms.Button btnChangeForeColor;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFileDialogMulti;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolderBrowsing;
    }
}