using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstUserControlProject
{
    public partial class ctrlSimpleCalc : UserControl
    {
        public ctrlSimpleCalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResults.Text = ( Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text) ).ToString();
        }
    }
}
