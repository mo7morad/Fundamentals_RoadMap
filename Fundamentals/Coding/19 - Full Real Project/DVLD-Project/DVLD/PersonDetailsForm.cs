using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DVLD
{
    public partial class PersonDetailsForm : Form
    {
        // Import for moving the window
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public event EventHandler OnClose;

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
            // Fire the event to notify subscribers
            OnClose?.Invoke(this, EventArgs.Empty);
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                const int WM_NCLBUTTONDOWN = 0xA1;
                const int HTCAPTION = 0x2;
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseForm(sender, e);
        }
    }
}
