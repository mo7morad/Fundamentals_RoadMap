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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void poolTable_OnTableComplete(object sender, PoolTable.TableCompletedEventArgs e)
        {
            //PoolTable ptable = (PoolTable)sender;
            //The as keyword is a safer way to cast because it returns null if the cast fails,
            //instead of throwing an exception.

            PoolTable table = sender as PoolTable;
           
            if (table != null)
            {
                frmTableResult TableResult = new frmTableResult(table.TableTitle, table.TablePlayer, e.TotalFees,
                    e.TimeText, e.RatePerHour);
                TableResult .ShowDialog();

                //// Access properties from the PoolTable UserControl (if needed)
                //string tableTitle = table.TableTitle;

                //// Format the results using string interpolation
                //string TableResults = $@"
                //    Table Title: {tableTitle}
                //    Time Consumed: {e.TimeText}
                //    Total Seconds: {e.TimeInSeconds}
                //    Hourly Rate: {e.RatePerHour:C2}
                //    Total Fees: {e.TotalFees:C2}";

                //// Display the results in a MessageBox
                //MessageBox.Show(TableResults, "Game Session Results");
            }
        }
    }
}
