using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class usrCtrlDrivingLicenseAppInfo : UserControl
    {
        public usrCtrlDrivingLicenseAppInfo()
        {
            InitializeComponent();
        }



        private void linkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (int.TryParse(lblPersonID.Text, out int personID))
            {
                PersonDetailsForm personDetailsForm = new PersonDetailsForm(personID);
                personDetailsForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Person ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
