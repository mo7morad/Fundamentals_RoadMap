﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmShowPersonInfo : Form
    {

        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
            this.Size = new Size(700, 500);
            this.MinimumSize = new Size(600, 400);
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        public frmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonCard1.LoadPersonInfo(NationalNo);
            this.Size = new Size(700, 500);
            this.MinimumSize = new Size(600, 400);
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
