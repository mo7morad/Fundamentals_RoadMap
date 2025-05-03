using System;
using System.Windows.Forms;
using Entities;

namespace DVLD
{
    public partial class UserDetailsForm: Form
    {
        public UserDetailsForm()
        {
            InitializeComponent(0);
        }

        public UserDetailsForm(clsUser user)
        {
            InitializeComponent(user.PersonData.PersonID);
            PopulateUserInfo(user);
        }

        private void PopulateUserInfo(clsUser user)
        {
            lblUserID.Text += user.UserID.ToString();
            lblUserName.Text += user.UserName;
            lblIsActive.Text += user.IsActive ? "Yes" : "No";
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
