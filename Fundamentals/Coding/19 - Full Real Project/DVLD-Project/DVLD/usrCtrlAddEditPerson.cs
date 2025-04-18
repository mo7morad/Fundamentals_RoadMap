using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;

namespace DVLD
{
    public partial class usrCtrlAddEditPerson : UserControl
    {
        // Events
        public event EventHandler<EventArgs> OnSave;
        public event EventHandler<EventArgs> OnClose;

        // Properties for accessing form data
        public int PersonID { get; set; } = -1;
        public string FirstName { get => txtFirstName.Text; set => txtFirstName.Text = value; }
        public string SecondName { get => txtSecondName.Text; set => txtSecondName.Text = value; }
        public string ThirdName { get => txtThirdName.Text; set => txtThirdName.Text = value; }
        public string LastName { get => txtLastName.Text; set => txtLastName.Text = value; }
        public string NationalNumber { get => txtNationalNumber.Text; set => txtNationalNumber.Text = value; }
        public DateTime DateOfBirth { get => dtpDateOfBirth.Value; set => dtpDateOfBirth.Value = value; }
        public string Phone { get => txtPhone.Text; set => txtPhone.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string Country { get => cmbCountry.Text; set => cmbCountry.Text = value; }
        public string Gender
        {
            get => rbMale.Checked ? "M" : "F";
            set
            {
                if (value == "M")
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
            }
        }

        public usrCtrlAddEditPerson()
        {
            InitializeComponent();
            LoadCountries();
        }

        private void LoadCountries()
        {
            cmbCountry.SelectedItem = "Select Country";
            cmbCountry.DataSource = clsCountriesBussinessLayer.GetAllCountires();

        }

        public void SetMode(bool isNewRecord)
        {
            if (isNewRecord)
            {
                lblHeader.Text = "Add New Person";
                lblPersonIDValue.Text = "N/A";
                PersonID = -1;
                ClearForm();
            }
            else
            {
                lblHeader.Text = "Update Person";
                lblPersonIDValue.Text = PersonID.ToString();
            }
        }

        private void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtSecondName.Text = string.Empty;
            txtThirdName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtNationalNumber.Text = string.Empty;
            rbMale.Checked = true;
            dtpDateOfBirth.Value = DateTime.Now.AddYears(-18);
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cmbCountry.SelectedIndex = 0;
            pbUserImage.Image = null;
        }

        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select Person Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbUserImage.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateForm()
        {
            // Example validation - customize as needed
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNationalNumber.Text))
            {
                MessageBox.Show("National Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNationalNumber.Focus();
                return false;
            }

            // Add additional validation as needed

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            // Trigger the save event to notify parent form
            OnSave?.Invoke(this, EventArgs.Empty);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Trigger the close event to notify parent form
            OnClose?.Invoke(this, EventArgs.Empty);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys like backspace, and block digits
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancel input
            }
        }

    }
}