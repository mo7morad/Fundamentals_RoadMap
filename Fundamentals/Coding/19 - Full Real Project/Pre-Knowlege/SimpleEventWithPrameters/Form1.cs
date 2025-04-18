using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEventWithPrameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Subscribe to the event
            myUserControl1.CalculationComplete += MyUserControl1_CalculationComplete;
        }

        private void MyUserControl1_CalculationComplete(object sender, int result)
        {
            MessageBox.Show("Result = " + result);
        }
    }
}
