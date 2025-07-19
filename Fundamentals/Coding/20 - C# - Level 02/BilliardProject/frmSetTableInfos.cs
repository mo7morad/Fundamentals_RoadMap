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
    public partial class frmSetTableInfos : Form
    {
        public frmSetTableInfos()
        {
            InitializeComponent();
        }
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, string tableName,
            string playerName, int H_Rate, string picLocation); 

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        private void ctrlSetPoolInfos1_OnSettingInfosComplete(object sender, CtrlSetPoolInfos.PoolInfoEventArgs e)
        {
            DataBack?.Invoke(this, e.TableName ,e.PlayerName ,e.HourlyRate ,e.PicLocation );

            this.Close();
        }
    }
}
