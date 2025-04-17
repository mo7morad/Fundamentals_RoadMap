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
    public partial class PeopleForm : Form
    {
        public PeopleForm()
        {
            InitializeComponent();
            comboBoxFilterBy.SelectedIndex = 0; // Set default selected index to 0
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Corrected logic to check the selected index
            if (comboBoxFilterBy.SelectedIndex != 0)
            {
                txtBoxFilterBy.Visible = true;
            }
            else
            {
                // Apply the selected filter
                // ApplyFilter(comboBoxFilterBy.SelectedItem.ToString());
            }
        }
    }
}
