using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmDialogs : Form
    {
        public frmDialogs()
        {
            InitializeComponent();
        }

        private void btnChangBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)

            {

                textBox1.BackColor = colorDialog1.Color;

            }
        }

        private void btnChangeForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)

            {

                textBox1.ForeColor = colorDialog1.Color;

            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {

            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowEffects = true;
            // fontDialog1.ShowHelp = true;
           
            
            fontDialog1.Font = textBox1.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)

            {
         
                    textBox1.Font = fontDialog1.Font;
                    textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;
        }
    }
}
