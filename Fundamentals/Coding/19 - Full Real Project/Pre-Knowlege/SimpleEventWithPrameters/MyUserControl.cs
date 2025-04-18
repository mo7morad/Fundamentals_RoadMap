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
    public partial class MyUserControl : UserControl
    {
        // Event using standard EventHandler<T>
        public event EventHandler<int> CalculationComplete;

        public MyUserControl()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber1.Text, out int num1) && int.TryParse(txtNumber2.Text, out int num2))
            {
                int result = num1 + num2;
                lblResult.Text = result.ToString();
                CalculationComplete?.Invoke(this, result);
            }
            else
            {
                MessageBox.Show("Please enter valid integers.");
            }
        }
    }
}
