using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class PersonDetailsForm: Form
    {
        public PersonDetailsForm(int personID)
        {
            if (personID == 0)
            {
                MessageBox.Show("Person doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InitializeComponent(personID);
            usrCtrlPersonInfoCard.OnCloseClicked += CloseForm;
        }
        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
