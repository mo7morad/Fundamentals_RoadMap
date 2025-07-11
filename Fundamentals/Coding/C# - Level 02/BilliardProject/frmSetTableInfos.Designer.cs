namespace _8Pool
{
    partial class frmSetTableInfos
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
            this.ctrlSetPoolInfos1 = new _8Pool.CtrlSetPoolInfos();
            this.SuspendLayout();
            // 
            // ctrlSetPoolInfos1
            // 
            this.ctrlSetPoolInfos1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlSetPoolInfos1.Location = new System.Drawing.Point(-1, 1);
            this.ctrlSetPoolInfos1.Name = "ctrlSetPoolInfos1";
            this.ctrlSetPoolInfos1.Size = new System.Drawing.Size(580, 352);
            this.ctrlSetPoolInfos1.TabIndex = 0;
            this.ctrlSetPoolInfos1.OnSettingInfosComplete += new System.EventHandler<_8Pool.CtrlSetPoolInfos.PoolInfoEventArgs>(this.ctrlSetPoolInfos1_OnSettingInfosComplete);
            // 
            // frmSetTableInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 348);
            this.Controls.Add(this.ctrlSetPoolInfos1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetTableInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Table Infos";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlSetPoolInfos ctrlSetPoolInfos1;
    }
}