﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form frm2 = new Form2();

            frm2.MdiParent = this;

            frm2.Show();

        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find client is here.");

        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Client   is here.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit is here.");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 frm2= new Form2();    
            frm2.MdiParent = this;
            frm2.Show();    

        }
    }
   
}
