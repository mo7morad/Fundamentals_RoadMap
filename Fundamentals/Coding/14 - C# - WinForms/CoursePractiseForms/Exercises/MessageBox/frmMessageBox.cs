using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is a message!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi this is a message!","this is a title koko");

        }

        private void button3_Click(object sender, EventArgs e)
        {
         if(   MessageBox.Show("Are You Sure?","Confirm", MessageBoxButtons.OKCancel) ==DialogResult.OK )
            {
                //do somthing
                MessageBox.Show("User Pressed Ok");

            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question ) == DialogResult.OK)
            {
                //do somthing
                MessageBox.Show("User Pressed Ok");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                //do somthing
                MessageBox.Show("User Pressed Ok");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is just for testing", "this is a title", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign, true);
        }
    }
}
