namespace Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picTicTacToe = new System.Windows.Forms.PictureBox();
            this.lblTicTacToe = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grbMainBox = new System.Windows.Forms.GroupBox();
            this.grbCenterBox = new System.Windows.Forms.GroupBox();
            this.picCenterTop = new System.Windows.Forms.PictureBox();
            this.picCenterMiddle = new System.Windows.Forms.PictureBox();
            this.picCenterBottom = new System.Windows.Forms.PictureBox();
            this.grbLeftBox = new System.Windows.Forms.GroupBox();
            this.picLeftTop = new System.Windows.Forms.PictureBox();
            this.picLeftCenter = new System.Windows.Forms.PictureBox();
            this.picLeftBottom = new System.Windows.Forms.PictureBox();
            this.grbRightBox = new System.Windows.Forms.GroupBox();
            this.picRightTop = new System.Windows.Forms.PictureBox();
            this.picRightCenter = new System.Windows.Forms.PictureBox();
            this.picRightBottom = new System.Windows.Forms.PictureBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblFinalWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTicTacToe)).BeginInit();
            this.grbMainBox.SuspendLayout();
            this.grbCenterBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCenterTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenterMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenterBottom)).BeginInit();
            this.grbLeftBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftBottom)).BeginInit();
            this.grbRightBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // picTicTacToe
            // 
            this.picTicTacToe.Image = global::Tic_Tac_Toe.Properties.Resources.Tic_Tac_Toe;
            this.picTicTacToe.Location = new System.Drawing.Point(12, 12);
            this.picTicTacToe.Name = "picTicTacToe";
            this.picTicTacToe.Size = new System.Drawing.Size(207, 194);
            this.picTicTacToe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTicTacToe.TabIndex = 0;
            this.picTicTacToe.TabStop = false;
            // 
            // lblTicTacToe
            // 
            this.lblTicTacToe.AutoSize = true;
            this.lblTicTacToe.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicTacToe.ForeColor = System.Drawing.Color.Cyan;
            this.lblTicTacToe.Location = new System.Drawing.Point(48, 209);
            this.lblTicTacToe.Name = "lblTicTacToe";
            this.lblTicTacToe.Size = new System.Drawing.Size(130, 31);
            this.lblTicTacToe.TabIndex = 1;
            this.lblTicTacToe.Text = "Tic Tac Toe";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(78, 278);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(70, 32);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Turn";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Cyan;
            this.lblPlayer.Location = new System.Drawing.Point(57, 330);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(113, 32);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Tag = "";
            this.lblPlayer.Text = "Player 1";
            // 
            // btnRestart
            // 
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(43, 416);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(141, 56);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // grbMainBox
            // 
            this.grbMainBox.AutoSize = true;
            this.grbMainBox.BackColor = System.Drawing.Color.Transparent;
            this.grbMainBox.Controls.Add(this.grbCenterBox);
            this.grbMainBox.Controls.Add(this.grbLeftBox);
            this.grbMainBox.Controls.Add(this.grbRightBox);
            this.grbMainBox.Location = new System.Drawing.Point(393, 12);
            this.grbMainBox.Name = "grbMainBox";
            this.grbMainBox.Size = new System.Drawing.Size(395, 350);
            this.grbMainBox.TabIndex = 5;
            this.grbMainBox.TabStop = false;
            // 
            // grbCenterBox
            // 
            this.grbCenterBox.Controls.Add(this.picCenterTop);
            this.grbCenterBox.Controls.Add(this.picCenterMiddle);
            this.grbCenterBox.Controls.Add(this.picCenterBottom);
            this.grbCenterBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCenterBox.Location = new System.Drawing.Point(128, 16);
            this.grbCenterBox.Name = "grbCenterBox";
            this.grbCenterBox.Size = new System.Drawing.Size(139, 331);
            this.grbCenterBox.TabIndex = 2;
            this.grbCenterBox.TabStop = false;
            // 
            // picCenterTop
            // 
            this.picCenterTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCenterTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picCenterTop.Image = ((System.Drawing.Image)(resources.GetObject("picCenterTop.Image")));
            this.picCenterTop.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCenterTop.InitialImage")));
            this.picCenterTop.Location = new System.Drawing.Point(3, 10);
            this.picCenterTop.Name = "picCenterTop";
            this.picCenterTop.Size = new System.Drawing.Size(133, 106);
            this.picCenterTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCenterTop.TabIndex = 5;
            this.picCenterTop.TabStop = false;
            this.picCenterTop.Click += new System.EventHandler(this.picCenterTop_Click);
            // 
            // picCenterMiddle
            // 
            this.picCenterMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCenterMiddle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picCenterMiddle.Image = ((System.Drawing.Image)(resources.GetObject("picCenterMiddle.Image")));
            this.picCenterMiddle.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCenterMiddle.InitialImage")));
            this.picCenterMiddle.Location = new System.Drawing.Point(3, 116);
            this.picCenterMiddle.Name = "picCenterMiddle";
            this.picCenterMiddle.Size = new System.Drawing.Size(133, 106);
            this.picCenterMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCenterMiddle.TabIndex = 4;
            this.picCenterMiddle.TabStop = false;
            this.picCenterMiddle.Click += new System.EventHandler(this.picCenterMiddle_Click);
            // 
            // picCenterBottom
            // 
            this.picCenterBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCenterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picCenterBottom.Image = ((System.Drawing.Image)(resources.GetObject("picCenterBottom.Image")));
            this.picCenterBottom.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCenterBottom.InitialImage")));
            this.picCenterBottom.Location = new System.Drawing.Point(3, 222);
            this.picCenterBottom.Name = "picCenterBottom";
            this.picCenterBottom.Size = new System.Drawing.Size(133, 106);
            this.picCenterBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCenterBottom.TabIndex = 3;
            this.picCenterBottom.TabStop = false;
            this.picCenterBottom.Click += new System.EventHandler(this.picCenterBottom_Click);
            // 
            // grbLeftBox
            // 
            this.grbLeftBox.Controls.Add(this.picLeftTop);
            this.grbLeftBox.Controls.Add(this.picLeftCenter);
            this.grbLeftBox.Controls.Add(this.picLeftBottom);
            this.grbLeftBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbLeftBox.Location = new System.Drawing.Point(3, 16);
            this.grbLeftBox.Name = "grbLeftBox";
            this.grbLeftBox.Size = new System.Drawing.Size(125, 331);
            this.grbLeftBox.TabIndex = 1;
            this.grbLeftBox.TabStop = false;
            // 
            // picLeftTop
            // 
            this.picLeftTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLeftTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picLeftTop.Image = ((System.Drawing.Image)(resources.GetObject("picLeftTop.Image")));
            this.picLeftTop.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLeftTop.InitialImage")));
            this.picLeftTop.Location = new System.Drawing.Point(3, 10);
            this.picLeftTop.Name = "picLeftTop";
            this.picLeftTop.Size = new System.Drawing.Size(119, 106);
            this.picLeftTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeftTop.TabIndex = 5;
            this.picLeftTop.TabStop = false;
            this.picLeftTop.Click += new System.EventHandler(this.picLeftTop_Click);
            // 
            // picLeftCenter
            // 
            this.picLeftCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLeftCenter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picLeftCenter.Image = ((System.Drawing.Image)(resources.GetObject("picLeftCenter.Image")));
            this.picLeftCenter.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLeftCenter.InitialImage")));
            this.picLeftCenter.Location = new System.Drawing.Point(3, 116);
            this.picLeftCenter.Name = "picLeftCenter";
            this.picLeftCenter.Size = new System.Drawing.Size(119, 106);
            this.picLeftCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeftCenter.TabIndex = 4;
            this.picLeftCenter.TabStop = false;
            this.picLeftCenter.Click += new System.EventHandler(this.picLeftCenter_Click);
            // 
            // picLeftBottom
            // 
            this.picLeftBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLeftBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picLeftBottom.Image = ((System.Drawing.Image)(resources.GetObject("picLeftBottom.Image")));
            this.picLeftBottom.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLeftBottom.InitialImage")));
            this.picLeftBottom.Location = new System.Drawing.Point(3, 222);
            this.picLeftBottom.Name = "picLeftBottom";
            this.picLeftBottom.Size = new System.Drawing.Size(119, 106);
            this.picLeftBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLeftBottom.TabIndex = 3;
            this.picLeftBottom.TabStop = false;
            this.picLeftBottom.Click += new System.EventHandler(this.picLeftBottom_Click);
            // 
            // grbRightBox
            // 
            this.grbRightBox.Controls.Add(this.picRightTop);
            this.grbRightBox.Controls.Add(this.picRightCenter);
            this.grbRightBox.Controls.Add(this.picRightBottom);
            this.grbRightBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbRightBox.Location = new System.Drawing.Point(267, 16);
            this.grbRightBox.Name = "grbRightBox";
            this.grbRightBox.Size = new System.Drawing.Size(125, 331);
            this.grbRightBox.TabIndex = 0;
            this.grbRightBox.TabStop = false;
            // 
            // picRightTop
            // 
            this.picRightTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRightTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picRightTop.Image = ((System.Drawing.Image)(resources.GetObject("picRightTop.Image")));
            this.picRightTop.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRightTop.InitialImage")));
            this.picRightTop.Location = new System.Drawing.Point(3, 10);
            this.picRightTop.Name = "picRightTop";
            this.picRightTop.Size = new System.Drawing.Size(119, 106);
            this.picRightTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRightTop.TabIndex = 2;
            this.picRightTop.TabStop = false;
            this.picRightTop.Click += new System.EventHandler(this.picRightTop_Click);
            // 
            // picRightCenter
            // 
            this.picRightCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRightCenter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picRightCenter.Image = ((System.Drawing.Image)(resources.GetObject("picRightCenter.Image")));
            this.picRightCenter.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRightCenter.InitialImage")));
            this.picRightCenter.Location = new System.Drawing.Point(3, 116);
            this.picRightCenter.Name = "picRightCenter";
            this.picRightCenter.Size = new System.Drawing.Size(119, 106);
            this.picRightCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRightCenter.TabIndex = 1;
            this.picRightCenter.TabStop = false;
            this.picRightCenter.Click += new System.EventHandler(this.picRightCenter_Click);
            // 
            // picRightBottom
            // 
            this.picRightBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picRightBottom.Image = ((System.Drawing.Image)(resources.GetObject("picRightBottom.Image")));
            this.picRightBottom.InitialImage = ((System.Drawing.Image)(resources.GetObject("picRightBottom.InitialImage")));
            this.picRightBottom.Location = new System.Drawing.Point(3, 222);
            this.picRightBottom.Name = "picRightBottom";
            this.picRightBottom.Size = new System.Drawing.Size(119, 106);
            this.picRightBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRightBottom.TabIndex = 0;
            this.picRightBottom.TabStop = false;
            this.picRightBottom.Click += new System.EventHandler(this.picRightBottom_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(517, 399);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(150, 41);
            this.lblWinner.TabIndex = 6;
            this.lblWinner.Text = "Winner:";
            // 
            // lblFinalWinner
            // 
            this.lblFinalWinner.AutoSize = true;
            this.lblFinalWinner.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalWinner.ForeColor = System.Drawing.Color.Yellow;
            this.lblFinalWinner.Location = new System.Drawing.Point(481, 454);
            this.lblFinalWinner.Name = "lblFinalWinner";
            this.lblFinalWinner.Size = new System.Drawing.Size(223, 41);
            this.lblFinalWinner.TabIndex = 7;
            this.lblFinalWinner.Text = "In Progress...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.lblFinalWinner);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblTicTacToe);
            this.Controls.Add(this.picTicTacToe);
            this.Controls.Add(this.grbMainBox);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picTicTacToe)).EndInit();
            this.grbMainBox.ResumeLayout(false);
            this.grbCenterBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCenterTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenterMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCenterBottom)).EndInit();
            this.grbLeftBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLeftTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftBottom)).EndInit();
            this.grbRightBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRightTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTicTacToe;
        private System.Windows.Forms.Label lblTicTacToe;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.GroupBox grbMainBox;
        private System.Windows.Forms.GroupBox grbCenterBox;
        private System.Windows.Forms.GroupBox grbLeftBox;
        private System.Windows.Forms.GroupBox grbRightBox;
        private System.Windows.Forms.PictureBox picRightBottom;
        private System.Windows.Forms.PictureBox picRightCenter;
        private System.Windows.Forms.PictureBox picCenterTop;
        private System.Windows.Forms.PictureBox picCenterMiddle;
        private System.Windows.Forms.PictureBox picCenterBottom;
        private System.Windows.Forms.PictureBox picLeftTop;
        private System.Windows.Forms.PictureBox picLeftCenter;
        private System.Windows.Forms.PictureBox picLeftBottom;
        private System.Windows.Forms.PictureBox picRightTop;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblFinalWinner;
    }
}

