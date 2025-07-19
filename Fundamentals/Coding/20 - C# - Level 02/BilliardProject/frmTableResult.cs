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
    public partial class frmTableResult : Form
    {
        private string _TableName;
        private string _PlayerName;
        private float _TotalFees;
        private string _TimeConsuming;
        private float _HourlyRate;

        public frmTableResult(string tableName,string playerName , float totalFees,
            string timeConsuming, float hourlyRate)
        {
            InitializeComponent();
            _TableName = tableName;
            _PlayerName = playerName;
            _TotalFees = totalFees;
            _HourlyRate = hourlyRate;
            _TimeConsuming = timeConsuming;
        }

        private void frmTableResult_Load(object sender, EventArgs e)
        {
            // Add columns to DataGridView
            dgvBilling.Columns.Add("Time Consuming", "Time Consumed (Hours)");
            dgvBilling.Columns.Add("HourlyRate", "Hourly Rate");
            dgvBilling.Columns.Add("TotalFees", "Total Fees");

            dgvBilling.Rows.Add(_TimeConsuming, _HourlyRate, _TotalFees);
            Font MyFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            dgvBilling.DefaultCellStyle.Font = MyFont;
            dgvBilling.ColumnHeadersDefaultCellStyle.Font = MyFont;

            dgvBilling.Columns[0].Width = 120;
            dgvBilling.Columns[1].Width = 130;
            dgvBilling.Columns[2].Width = 150;



            lblFees.Text = _TotalFees.ToString("F2");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
