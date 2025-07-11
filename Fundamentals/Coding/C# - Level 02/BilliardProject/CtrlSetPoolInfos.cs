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
    public partial class CtrlSetPoolInfos : UserControl
    {
        public CtrlSetPoolInfos()
        {
            InitializeComponent();
        }
        public class PoolInfoEventArgs : EventArgs  // inherits EventArgs
        {
            public string TableName { get; set; }
            public string PlayerName { get; set; }
            public int HourlyRate { get; set; }
            public string PicLocation { get; set; }


            // Parameterized constructor
            public PoolInfoEventArgs(string tableName, string playerName, int H_Rate, string picLocation)
            {
                this.TableName = tableName;
                this.PlayerName = playerName;
                this.HourlyRate = H_Rate;
                this.PicLocation = picLocation;
            }
        }

        // Define an event handler from PoolInfoEventArgs Type ( The Class );
        public event EventHandler<PoolInfoEventArgs> OnSettingInfosComplete;
        public void RaiseOnCalulationComplete(string tableName, string playerName, int H_Rate, string picLocation)
        {
            RaiseOnCalulationComplete(new PoolInfoEventArgs(tableName, playerName, H_Rate, picLocation));
        }

        // Virtual Function with e (PoolInfoEventArgs) as a parameter
        protected virtual void RaiseOnCalulationComplete(PoolInfoEventArgs e)
        {
            OnSettingInfosComplete?.Invoke(this, e);
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == string.Empty || txtTableName.Text == string.Empty)
            {
                MessageBox.Show("Some Field Not Setting!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ( nudHourlyRate.Value <= 0)
            {
                MessageBox.Show("Hourly Rate Cannot be 0!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RaiseOnCalulationComplete(txtTableName.Text , txtPlayerName.Text , (int)nudHourlyRate.Value, PictureFilePath);
            
        }
        private string PictureFilePath = "";
        private void llChoosePic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"Gallery";

            openFileDialog1.Title = "Choose An Image";

            openFileDialog1.DefaultExt = "png";
            openFileDialog1.Filter = "Image files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";/*All files (*.*)|*.**/
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PictureFilePath = openFileDialog1.FileName;
            }
        }
    }
}
