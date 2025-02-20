using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRestart.BackColor = Color.Transparent;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen WhitePen = new Pen(White);
            WhitePen.Width = 3;

            // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            WhitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            WhitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Drawing Line Under Turn Label
            e.Graphics.DrawLine(WhitePen, 65, 320, 155, 320);

            WhitePen.Width = 5;
            e.Graphics.DrawLine(WhitePen, 395, 139, 780, 139);
            e.Graphics.DrawLine(WhitePen, 395, 243, 780, 243);


        }

        private void picLeftTop_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                picLeftTop.Image = Properties.Resources.X;
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picLeftTop.Image = Properties.Resources.O;
                lblPlayer.Text = "Player 1";
            }
        }

        private void picCenterTop_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                picCenterTop.Image = Properties.Resources.X;
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picCenterTop.Image = Properties.Resources.O;
                lblPlayer.Text = "Player 1";
            }
        }

        private void picRightTop_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                picRightTop.Image = Properties.Resources.X;
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picRightTop.Image = Properties.Resources.O;
                lblPlayer.Text = "Player 1";
            }
        }

        private void picLeftCenter_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                picLeftCenter.Image = Properties.Resources.X;
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picLeftCenter.Image = Properties.Resources.O;
                lblPlayer.Text = "Player 1";
            }
        }

        private void picCenterMiddle_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                picCenterMiddle.Image = Properties.Resources.X;
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picCenterMiddle.Image = Properties.Resources.O;
                lblPlayer.Text = "Player 1";
            }
        }

        private void picRightCenter_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                picRightCenter.Image = Properties.Resources.X;
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picRightCenter.Image = Properties.Resources.O;
                lblPlayer.Text = "Player 1";
            }
        }

        private void picLeftBottom_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                picLeftBottom.Image = Properties.Resources.X;
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picLeftBottom.Image = Properties.Resources.O;
                lblPlayer.Text = "Player 1";
            }
        }

        private void picCenterBottom_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                picCenterBottom.Image = Properties.Resources.X;
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picCenterBottom.Image = Properties.Resources.O;
                lblPlayer.Text = "Player 1";
            }
        }

        private void picRightBottom_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                picRightBottom.Image = Properties.Resources.X;
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picRightBottom.Image = Properties.Resources.O;
                lblPlayer.Text = "Player 1";
            }
        }

        private void ResetGame()
        {
            picLeftTop.Image = Properties.Resources.QMark;
            picCenterTop.Image = Properties.Resources.QMark;
            picRightTop.Image = Properties.Resources.QMark;
            picLeftCenter.Image = Properties.Resources.QMark;
            picCenterMiddle.Image = Properties.Resources.QMark;
            picRightCenter.Image = Properties.Resources.QMark;
            picLeftBottom.Image = Properties.Resources.QMark;
            picCenterBottom.Image = Properties.Resources.QMark;
            picRightBottom.Image = Properties.Resources.QMark;
            lblPlayer.Text = "Player 1";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
