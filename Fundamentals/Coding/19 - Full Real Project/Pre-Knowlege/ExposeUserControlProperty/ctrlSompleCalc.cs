using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFirstUserControlProject
{
    public partial class ctrlSompleCalc : UserControl
    {
        public ctrlSompleCalc()
        {
            InitializeComponent();
        }

        public float Result   // property
        {
            get { return (float)Convert.ToDouble(lblResults.Text); }   // get method

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResults.Text = (int.Parse( textBox1.Text) + int.Parse(textBox2.Text)).ToString();

        }
    }
}
