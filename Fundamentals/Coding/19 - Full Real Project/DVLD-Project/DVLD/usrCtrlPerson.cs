using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using DVLD_Entities.Enums;



namespace DVLD
{
    public partial class usrCtrlPerson : UserControl
    {
        // Events
        public event EventHandler<EventArgs> OnSave;
        public event EventHandler<EventArgs> OnClose;

        // Properties for accessing form data
        public string PersonID { get => lblPersonIDValue.Text; set => lblPersonIDValue.Text = value; }
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
        public string ImagePath { get => pbUserImage.ImageLocation; set => pbUserImage.ImageLocation = value; }
        public char Gender
        {
            get => rbMale.Checked ? 'M' : 'F';
            set
            {
                if (value == 'M')
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
            }
        }

        private void LoadCountries()
        {
            cmbCountry.DataSource = clsCountriesBussinessLayer.GetAllCountires();
            cmbCountry.SelectedIndex = -1; // No default selection
            cmbCountry.Text = string.Empty;

        }
        //public void SetMode(bool isNewRecord)
        //{
        //    if (isNewRecord)
        //    {
        //        lblHeader.Text = "Add New Person";
        //        lblPersonIDValue.Text = "N/A";
        //        PersonID = -1;
        //        ClearForm();
        //    }
        //    else
        //    {
        //        lblHeader.Text = "Update Person";
        //        lblPersonIDValue.Text = PersonID.ToString();
        //    }
        //}
        private bool ValidateNationalNo()
        {
            if (string.IsNullOrWhiteSpace(txtNationalNumber.Text))
            {
                MessageBox.Show("National Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNationalNumber.Focus();
                return false;
            }
            else if (clsPeopleBusinessLayer.IsNationalNoExists(txtNationalNumber.Text))
            {
                MessageBox.Show("This National Number already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNationalNumber.Focus();
                return false;
            }
            return true;
        }
        private bool ValidateName()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return false;
            }

            else if (string.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                MessageBox.Show("Second Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSecondName.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtThirdName.Text))
            {
                MessageBox.Show("Third Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThirdName.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return false;
            }
            return true;
        }
        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return true;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Basic regex
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Invalid email format. Example: user@example.com",
                              "Validation Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            return true;
        }
        private bool ValidatePhone()
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return false;
            }
            else if (txtPhone.Text.Length < 10)
            {
                MessageBox.Show("Phone number must be at least 10 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return false;
            }
            return true;
        }
        private bool ValidateAddress()
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return false;
            }
            return true;
        }
        private bool ValidateCountry()
        {
            if (cmbCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a country.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCountry.Focus();
                return false;
            }
            return true;
        }
        private bool ValidateForm()
        {
            if (!ValidateName())
                return false;

            else if (!ValidateNationalNo())
                return false;

            else if (!ValidateEmail())
                return false;

            else if (!ValidatePhone())
            {
                return false;
            }
            else if (!ValidateAddress())
                return false;
            else if (!ValidateCountry())
                return false;

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            if (pbUserImage.ImageLocation != null)
            {
                string sourcePath = pbUserImage.ImageLocation;
                string extension = Path.GetExtension(sourcePath);
                string nationalID = txtNationalNumber.Text;
                string targetDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DVLD", "peoplepictures");
                Directory.CreateDirectory(targetDir);
                string destPath = Path.Combine(targetDir, nationalID + extension);

                try
                {
                    File.Copy(sourcePath, destPath, true); // overwrite if already exists
                    pbUserImage.ImageLocation = destPath;  // update the image path to the copied one
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to copy image: " + ex.Message);
                }
            }

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
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow only digits and control keys
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancel input
            }
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbUserImage.Image = Properties.Resources.DefaultMan;
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbUserImage.Image = Properties.Resources.DefaultWoman;
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
                    pbUserImage.ImageLocation = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void lblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Remove the image
            if (rbMale.Checked)
                pbUserImage.Image = Properties.Resources.DefaultMan;
            else
                pbUserImage.Image = Properties.Resources.DefaultWoman;
            pbUserImage.ImageLocation = null;
            lblRemoveImage.Visible = false;
        }

        public usrCtrlPerson() : this(enFormMode.AddNew)
        {

        }
        public usrCtrlPerson(enFormMode formMode, int personID=-1)
        {
            InitializeComponent();
            LoadCountries();
            if (formMode == enFormMode.AddNew)
            {
                lblHeader.Text = "Add New Person";
                lblPersonIDValue.Text = "N/A";
            }
            else
            {
                lblHeader.Text = "Update Person";
                PersonID = personID.ToString();
                lblRemoveImage.Visible = true;
            }
        }
    }
}