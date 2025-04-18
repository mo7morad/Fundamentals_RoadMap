using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SendDataBackToFromUsingDelgate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.DataBack += Form2_DataBack; // Subscribe to the event
           
            frm2.ShowDialog();

        }


        private void Form2_DataBack(object sender, int PersonID)
        {
            // Handle the data received from Form2
           textBox1.Text= PersonID.ToString();


        }
       





    }
}
