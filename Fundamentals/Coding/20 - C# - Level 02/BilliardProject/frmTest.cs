using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Pool
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void poolTable1_OnTableComplete_1(object sender, PoolTable.TableCompletedEventArgs e)
        {
            string TableResults = "";

            TableResults = "Time Consumed " + e.TimeText;
            TableResults = TableResults + ", Total Seconds= " + e.TimeInSeconds;
            TableResults = TableResults + ", HourlyRate=" + e.RatePerHour.ToString();
            TableResults = TableResults + ", Total Fees=" + e.TotalFees.ToString();

            MessageBox.Show(TableResults);
        }
    }
}
