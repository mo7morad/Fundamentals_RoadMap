using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataBackToFromUsingDelgate
{
    public partial class Form2 : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        public Form2()
        {
            InitializeComponent();
        }

        private void SendDataBack_Click(object sender, EventArgs e)
        {
            int  PersonID  = int.Parse(txtPersonID.Text);

            // Trigger the event to send data back to Form1
            DataBack?.Invoke(this, PersonID);

           
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
