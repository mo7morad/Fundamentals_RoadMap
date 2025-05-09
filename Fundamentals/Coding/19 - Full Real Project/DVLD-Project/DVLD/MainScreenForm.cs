using BusinessLayer;
using Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            // Form styling
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;

            // MenuStrip styling
            MainMenuStrip.Renderer = new ModernMenuRenderer();
            MainMenuStrip.Padding = new Padding(10, 5, 10, 5);
            MainMenuStrip.BackColor = Color.FromArgb(45, 50, 80);

            // Style each menu item
            foreach (ToolStripMenuItem item in MainMenuStrip.Items)
            {
                StyleMenuItem(item);

                // Style dropdown items if they exist
                if (item.DropDownItems.Count > 0)
                {
                    foreach (ToolStripItem dropDownItem in item.DropDownItems)
                    {
                        if (dropDownItem is ToolStripMenuItem menuItem)
                        {
                            StyleDropDownMenuItem(menuItem);
                        }
                    }
                }
            }
        }

        private void StyleMenuItem(ToolStripMenuItem item)
        {
            item.ForeColor = Color.White;
            item.Padding = new Padding(15, 5, 15, 5);
            item.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            // Add hover effect via event handlers
            item.MouseEnter += (s, e) => {
                item.ForeColor = Color.FromArgb(255, 207, 84);
                item.BackColor = Color.FromArgb(65, 70, 100);
            };

            item.MouseLeave += (s, e) => {
                item.ForeColor = Color.White;
                item.BackColor = Color.FromArgb(45, 50, 80);
            };
        }

        private void StyleDropDownMenuItem(ToolStripMenuItem item)
        {
            item.ForeColor = Color.FromArgb(40, 40, 40);
            item.BackColor = Color.FromArgb(240, 240, 240);

            // Ensure proper image display
            if (item.Image != null)
            {
                // Use None for Account Settings submenu items to preserve original size
                // This gives better display quality than SizeToFit
                item.ImageScaling = ToolStripItemImageScaling.None;
                item.ImageAlign = ContentAlignment.MiddleLeft;
                
                // Only increase padding if it's in the Account Settings dropdown
                if (item.OwnerItem == menuStripAccountSettingsItem)
                {
                    item.Padding = new Padding(5, 5, 5, 5);
                }
            }

            // Add hover effect for dropdown items
            item.MouseEnter += (s, e) => {
                item.ForeColor = Color.FromArgb(0, 0, 0);
                item.BackColor = Color.FromArgb(225, 225, 225);
            };

            item.MouseLeave += (s, e) => {
                item.ForeColor = Color.FromArgb(40, 40, 40);
                item.BackColor = Color.FromArgb(240, 240, 240);
            };
        }

        private void menuStripPeopleItem_Click(object sender, EventArgs e)
        {
            ManagePeopleForm peopleFrm = new ManagePeopleForm();
            peopleFrm.ShowDialog();
        }

        private void menuStripUsersItem_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm();
            manageUsersForm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreenForm loginScreenForm = new LoginScreenForm();
            loginScreenForm.FormClosed += (s, args) => this.Close();
            loginScreenForm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser user = clsUsersBusinessLayer.GetUserByUserName(clsCurrentSession.LoggedInUserName);
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(user);
            changePasswordForm.ShowDialog();
        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser user = clsUsersBusinessLayer.GetUserByUserName(clsCurrentSession.LoggedInUserName);
            UserDetailsForm currentUserForm = new UserDetailsForm(user);
            currentUserForm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypesForm frm = new ManageApplicationTypesForm();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypesForm manageTestTypesForm = new ManageTestTypesForm();
            manageTestTypesForm.ShowDialog();
        }
        private void subLocalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplicationForm frm = new LocalDrivingLicenseApplicationForm();
            frm.ShowDialog();
        }

        private void manageLocalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicenseApplicationForm frm = new ManageLocalDrivingLicenseApplicationForm();
            frm.ShowDialog();
        }
    }



    // Custom renderer for modern menu style
    public class ModernMenuRenderer : ToolStripProfessionalRenderer
    {
        public ModernMenuRenderer() : base(new ModernColors())
        {
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            // Add a slight shadow to the text
            if (e.Item.Selected)
            {
                e.TextColor = Color.FromArgb(255, 207, 84);
                base.OnRenderItemText(e);
            }
            else
            {
                base.OnRenderItemText(e);
            }
        }
    }

    // Custom color scheme for menu
    public class ModernColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(65, 70, 100);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(65, 70, 100);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(65, 70, 100);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(65, 70, 100);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(65, 70, 100);
        public override Color MenuBorder => Color.FromArgb(45, 50, 80);
        public override Color MenuItemBorder => Color.Transparent;
    }
}
