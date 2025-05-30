﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using Entities;
using Entities.Enums;

namespace DVLD
{
    public partial class usrCtrlPerson : UserControl
    {
        private enFormMode _FormMode;
        public event EventHandler<EventArgs> OnSave;
        public event EventHandler<EventArgs> OnClose;
        //
        // Properties
        //
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

        public bool Gender
        {
            get => rbMale.Checked ? false : true;
            set
            {
                rbMale.Checked = !value;     // false => Male, true => Female
                rbFemale.Checked = value;
            }
        }


        //
        // Constructors
        //
        public usrCtrlPerson() : this(enFormMode.AddNew) { }

        public usrCtrlPerson(enFormMode formMode, int personID = -1)
        {
            _FormMode = formMode;
            InitializeComponent();
            PersonID = personID.ToString();
            LoadCountries();
            SetupFormMode();
        }
        
        //
        // Validation Code
        //
        private void LoadCountries()
        {
            cmbCountry.DataSource = clsCountriesBusinessLayer.GetAllCountires();
            cmbCountry.SelectedIndex = 50;
            cmbCountry.Text = string.Empty;
        }

        private bool ValidateForm()
        {
            return ValidateName() && ValidateNationalNo() && ValidateEmail() && ValidatePhone() && ValidateAddress() && ValidateCountry();
        }

        private bool ValidateNationalNo()
        {
            if (!clsPersonService.ValidateNationalNo(NationalNumber, int.TryParse(PersonID, out int personId) ? personId : -1))
            {
                if (string.IsNullOrWhiteSpace(NationalNumber))
                    ShowValidationError("National Number is required.", txtNationalNumber);
                else
                    ShowValidationError("This National Number already exists.", txtNationalNumber);
                return false;
            }
            return true;
        }

        private bool ValidateName()
        {
            if (!clsPersonService.ValidateName(FirstName, SecondName, ThirdName, LastName))
            {
                if (string.IsNullOrWhiteSpace(FirstName)) 
                    return ShowValidationError("First Name is required.", txtFirstName);
                if (string.IsNullOrWhiteSpace(SecondName)) 
                    return ShowValidationError("Second Name is required.", txtSecondName);
                if (string.IsNullOrWhiteSpace(ThirdName)) 
                    return ShowValidationError("Third Name is required.", txtThirdName);
                if (string.IsNullOrWhiteSpace(LastName))
                    return ShowValidationError("Last Name is required.", txtLastName);
                return false;
            }
            return true;
        }

        private bool ValidateEmail()
        {
            if (!clsPersonService.ValidateEmail(Email))
            {
                ShowValidationError("Invalid email format. Example: user@example.com", txtEmail);
                return false;
            }
            return true;
        }

        private bool ValidatePhone()
        {
            if (!clsPersonService.ValidatePhone(Phone))
            {
                if (string.IsNullOrWhiteSpace(Phone))
                    return ShowValidationError("Phone number is required.", txtPhone);
                else
                    return ShowValidationError("Phone number must be at least 10 digits long.", txtPhone);
            }
            return true;
        }

        private bool ValidateAddress()
        {
            return (string.IsNullOrWhiteSpace(Address)) ? ShowValidationError("Address is required.", txtAddress) : true;
        }

        private bool ValidateCountry()
        {
            return cmbCountry.SelectedIndex != -1 || ShowValidationError("Please select a country.", cmbCountry);
        }

        private bool ShowValidationError(string message, Control control)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
            return false;
        }

        //
        // Event Handlers
        //
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            if (!string.IsNullOrEmpty(ImagePath)) SaveUserImage();

            OnSave?.Invoke(this, EventArgs.Empty);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnClose?.Invoke(this, EventArgs.Empty);
        }

        //
        // Image Handling
        //
        private void SaveUserImage()
        {
            if (string.IsNullOrEmpty(ImagePath))
                return;
                
            string newImagePath = clsPersonService.SavePersonImage(ImagePath, NationalNumber);
            if (!string.IsNullOrEmpty(newImagePath))
            {
                pbUserImage.ImageLocation = newImagePath;
            }
            else
            {
                MessageBox.Show("Failed to save image.", "Image Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void TryLoadImage(string filePath)
        {
            if(string.IsNullOrEmpty(filePath))
            {
                SetDefaultImageByGender();
                lblRemoveImage.Visible = false;
                return;
            }
            
            try
            {
                Image image = clsPersonService.GetPersonImage(filePath, Gender);
                if (image != null)
                {
                    pbUserImage.Image = image;
                    pbUserImage.ImageLocation = filePath;
                    lblRemoveImage.Visible = true;
                }
                else
                {
                    SetDefaultImageByGender();
                    pbUserImage.ImageLocation = null;
                    lblRemoveImage.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Failed to load the selected image. Reverting to default.", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefaultImageByGender();
                pbUserImage.ImageLocation = null;
                lblRemoveImage.Visible = false;
            }
        }
        
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ImagePath))
                pbUserImage.Image = Properties.Resources.DefaultMan;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ImagePath))
                pbUserImage.Image = Properties.Resources.DefaultWoman;
        }

        private void SetDefaultImageByGender()
        {
            pbUserImage.Image = rbMale.Checked ? Properties.Resources.DefaultMan : Properties.Resources.DefaultWoman;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsFormDataService.IsAlphabeticKey(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !clsFormDataService.IsNumericKey(e.KeyChar, false);
        }

        //
        // Logic Handling
        //
        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select Person Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                TryLoadImage(openFileDialog.FileName);
        }

        private void lblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetDefaultImageByGender();
            ImagePath = null;
            lblRemoveImage.Visible = false;
        }

        private void SetupUpdatePersonData()
        {
            if (!int.TryParse(PersonID, out int personId)) return;

            clsPerson person = clsPeopleBusinessLayer.GetPersonByID(personId);
            if (person == null) return;

            lblHeader.Text = "Update Person";
            if (string.IsNullOrEmpty(ImagePath)) lblRemoveImage.Visible = false;

            NationalNumber = person.NationalNo;
            FirstName = person.FirstName;
            SecondName = person.SecondName;
            ThirdName = person.ThirdName;
            LastName = person.LastName;
            DateOfBirth = person.DateOfBirth;
            Gender = person.Gender;
            Phone = person.Phone;
            Email = person.Email;
            Address = person.Address;
            Country = person.Country.CountryName;
            TryLoadImage(person.ImagePath);
        }

        private void SetupFormMode()
        {
            if (_FormMode == enFormMode.AddNew)
            {
                lblHeader.Text = "Add New Person";
                lblPersonIDValue.Text = "N/A";
                SetDefaultImageByGender();
            }
            else if (_FormMode == enFormMode.Update)
            {
                SetupUpdatePersonData();
            }
        }
    }
}
