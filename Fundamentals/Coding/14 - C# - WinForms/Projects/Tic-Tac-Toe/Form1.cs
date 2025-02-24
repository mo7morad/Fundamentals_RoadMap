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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRestart.BackColor = Color.Transparent;
            ResetGame();
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

        private bool CheckDiagonals()
        {
            if (picLeftTop.Tag.ToString() != "QMark" && (picLeftTop.Tag == picCenterMiddle.Tag) && (picCenterMiddle.Tag == picRightBottom.Tag))
            {
                picLeftTop.BackColor = picCenterMiddle.BackColor = picRightBottom.BackColor = Color.Green;
                return true;
            }
            else if (picRightTop.Tag.ToString() != "QMark" && (picRightTop.Tag == picCenterMiddle.Tag) && (picCenterMiddle.Tag == picLeftBottom.Tag))
            {
                picRightTop.BackColor = picCenterMiddle.BackColor = picLeftBottom.BackColor = Color.Green;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckRows()
        {
            if (picLeftTop.Tag.ToString() != "QMark" && (picLeftTop.Tag == picCenterTop.Tag) && (picCenterTop.Tag == picRightTop.Tag))
            {
                picLeftTop.BackColor = picCenterTop.BackColor = picRightTop.BackColor = Color.Green;
                return true;
            }
            else if (picLeftCenter.Tag.ToString() != "QMark" && (picLeftCenter.Tag == picCenterMiddle.Tag) && (picCenterMiddle.Tag == picRightCenter.Tag))
            {
                picLeftCenter.BackColor = picCenterMiddle.BackColor = picRightCenter.BackColor = Color.Green;
                return true;
            }
            else if (picLeftBottom.Tag.ToString() != "QMark" && (picLeftBottom.Tag == picCenterBottom.Tag) && (picCenterBottom.Tag == picRightBottom.Tag))
            {
                picLeftBottom.BackColor = picCenterBottom.BackColor = picRightBottom.BackColor = Color.Green;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckCols()
        {
            if (picLeftTop.Tag.ToString() != "QMark" && (picLeftTop.Tag == picLeftCenter.Tag) && (picLeftCenter.Tag == picLeftBottom.Tag))
            {
                picLeftTop.BackColor = picLeftCenter.BackColor = picLeftBottom.BackColor = Color.Green;
                return true;
            }
            else if (picCenterTop.Tag.ToString() != "QMark" && (picCenterTop.Tag == picCenterMiddle.Tag) && (picCenterMiddle.Tag == picCenterBottom.Tag))
            {
                picCenterTop.BackColor = picCenterMiddle.BackColor = picCenterBottom.BackColor = Color.Green;
                return true;
            }
            else if (picRightTop.Tag.ToString() != "QMark" && (picRightTop.Tag == picRightCenter.Tag) && (picRightCenter.Tag == picRightBottom.Tag))
            {
                picRightTop.BackColor = picRightCenter.BackColor = picRightBottom.BackColor = Color.Green;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CheckWinner()
        {
            if (CheckDiagonals() || CheckRows() || CheckCols())
            {
                if (lblPlayer.Text == "Player 1")
                {
                    lblFinalWinner.Text = "Player 2!";
                    MessageBox.Show("Player 2 Wins!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblFinalWinner.Text = "Player 1!";
                    MessageBox.Show("Player 1 Wins!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetGame();
            }
            else
            {
                if (picLeftTop.Tag.ToString() != "QMark" && picCenterTop.Tag.ToString() != "QMark" && picRightTop.Tag.ToString() != "QMark" && picLeftCenter.Tag.ToString() != "QMark" && picCenterMiddle.Tag.ToString() != "QMark" && picRightCenter.Tag.ToString() != "QMark" && picLeftBottom.Tag.ToString() != "QMark" && picCenterBottom.Tag.ToString() != "QMark" && picRightBottom.Tag.ToString() != "QMark")
                {
                    MessageBox.Show("It's a Draw!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                }
            }
        }

        private void picLeftTop_Click(object sender, EventArgs e)
        {
            if (picLeftTop.Tag.ToString() != "QMark")
            {
                MessageBox.Show("This spot is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblPlayer.Text == "Player 1")
            {
                picLeftTop.Image = Properties.Resources.X;
                picLeftTop.Tag = "X";
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picLeftTop.Image = Properties.Resources.O;
                picLeftTop.Tag = "O";
                lblPlayer.Text = "Player 1";
            }
            CheckWinner();
        }

        private void picCenterTop_Click(object sender, EventArgs e)
        {
            if (picCenterTop.Tag.ToString() != "QMark")
            {
                MessageBox.Show("This spot is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblPlayer.Text == "Player 1")
            {
                picCenterTop.Image = Properties.Resources.X;
                picCenterTop.Tag = "X";
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picCenterTop.Image = Properties.Resources.O;
                picCenterTop.Tag = "O";
                lblPlayer.Text = "Player 1";
            }
            CheckWinner();
        }

        private void picRightTop_Click(object sender, EventArgs e)
        {
            if (picRightTop.Tag.ToString() != "QMark")
            {
                MessageBox.Show("This spot is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblPlayer.Text == "Player 1")
            {
                picRightTop.Image = Properties.Resources.X;
                picRightTop.Tag = "X";
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picRightTop.Image = Properties.Resources.O;
                picRightTop.Tag = "O";
                lblPlayer.Text = "Player 1";
            }
            CheckWinner();
        }

        private void picLeftCenter_Click(object sender, EventArgs e)
        {
            if (picLeftCenter.Tag.ToString() != "QMark")
            {
                MessageBox.Show("This spot is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblPlayer.Text == "Player 1")
            {
                picLeftCenter.Image = Properties.Resources.X;
                picLeftCenter.Tag = "X";
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picLeftCenter.Image = Properties.Resources.O;
                picLeftCenter.Tag = "O";
                lblPlayer.Text = "Player 1";
            }
            CheckWinner();
        }

        private void picCenterMiddle_Click(object sender, EventArgs e)
        {
            if (picCenterMiddle.Tag.ToString() != "QMark")
            {
                MessageBox.Show("This spot is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblPlayer.Text == "Player 1")
            {
                picCenterMiddle.Image = Properties.Resources.X;
                picCenterMiddle.Tag = "X";
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picCenterMiddle.Image = Properties.Resources.O;
                picCenterMiddle.Tag = "O";
                lblPlayer.Text = "Player 1";
            }
            CheckWinner();
        }

        private void picRightCenter_Click(object sender, EventArgs e)
        {
            if (picRightCenter.Tag.ToString() != "QMark")
            {
                MessageBox.Show("This spot is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblPlayer.Text == "Player 1")
            {
                picRightCenter.Image = Properties.Resources.X;
                picRightCenter.Tag = "X";
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picRightCenter.Image = Properties.Resources.O;
                picRightCenter.Tag = "O";
                lblPlayer.Text = "Player 1";
            }
            CheckWinner();
        }

        private void picLeftBottom_Click(object sender, EventArgs e)
        {
            if (picLeftBottom.Tag.ToString() != "QMark")
            {
                MessageBox.Show("This spot is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblPlayer.Text == "Player 1")
            {
                picLeftBottom.Image = Properties.Resources.X;
                picLeftBottom.Tag = "X";
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picLeftBottom.Image = Properties.Resources.O;
                picLeftBottom.Tag = "O";
                lblPlayer.Text = "Player 1";
            }
            CheckWinner();
        }

        private void picCenterBottom_Click(object sender, EventArgs e)
        {
            if (picCenterBottom.Tag.ToString() != "QMark")
            {
                MessageBox.Show("This spot is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblPlayer.Text == "Player 1")
            {
                picCenterBottom.Image = Properties.Resources.X;
                picCenterBottom.Tag = "X";
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picCenterBottom.Image = Properties.Resources.O;
                picCenterBottom.Tag = "O";
                lblPlayer.Text = "Player 1";
            }
            CheckWinner();
        }

        private void picRightBottom_Click(object sender, EventArgs e)
        {
            if (picRightBottom.Tag.ToString() != "QMark")
            {
                MessageBox.Show("This spot is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lblPlayer.Text == "Player 1")
            {
                picRightBottom.Image = Properties.Resources.X;
                picRightBottom.Tag = "X";
                lblPlayer.Text = "Player 2";
            }
            else
            {
                picRightBottom.Image = Properties.Resources.O;
                picRightBottom.Tag = "O";
                lblPlayer.Text = "Player 1";
            }
            CheckWinner();
        }

        private void ResetGame()
        {
            picLeftTop.Image = Properties.Resources.QMark;
            picLeftTop.BackColor = Color.Transparent;
            picLeftTop.Tag = "QMark";

            picCenterTop.Image = Properties.Resources.QMark;
            picCenterTop.BackColor = Color.Transparent;
            picCenterTop.Tag = "QMark";

            picRightTop.Image = Properties.Resources.QMark;
            picRightTop.BackColor = Color.Transparent;
            picRightTop.Tag = "QMark";

            picLeftCenter.Image = Properties.Resources.QMark;
            picLeftCenter.BackColor = Color.Transparent;
            picLeftCenter.Tag = "QMark";

            picCenterMiddle.Image = Properties.Resources.QMark;
            picCenterMiddle.BackColor = Color.Transparent;
            picCenterMiddle.Tag = "QMark";

            picRightCenter.Image = Properties.Resources.QMark;
            picRightCenter.BackColor = Color.Transparent;
            picRightCenter.Tag = "QMark";

            picLeftBottom.Image = Properties.Resources.QMark;
            picLeftBottom.BackColor = Color.Transparent;
            picLeftBottom.Tag = "QMark";

            picCenterBottom.Image = Properties.Resources.QMark;
            picCenterBottom.BackColor = Color.Transparent;
            picCenterBottom.Tag = "QMark";

            picRightBottom.Image = Properties.Resources.QMark;
            picRightBottom.BackColor = Color.Transparent;
            picRightBottom.Tag = "QMark";

            lblPlayer.Text = "Player 1";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
