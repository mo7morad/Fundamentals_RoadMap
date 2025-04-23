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
        public PersonDetailsForm():this(0)
        {
            InitializeComponent();
        }
        public PersonDetailsForm(int personID)
        {
            InitializeComponent(personID);
        }
    }
}
