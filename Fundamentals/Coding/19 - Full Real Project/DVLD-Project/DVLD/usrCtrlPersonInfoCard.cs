using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using BusinessLayer;
using Entities;
using Entities.Enums;

namespace DVLD
{
    public partial class usrCtrlPersonInfoCard : UserControl
    {
        // Event for the close button
        public event EventHandler OnCloseClicked;

        // Properties for getting and setting values
        public string PersonID
        {
            get { return lblPersonIDValue.Text; }
            set { lblPersonIDValue.Text = value; }
        }
        public string FullName
        {
            get { return lblNameValue.Text; }
            set { lblNameValue.Text = value; }
        }
        public string NationalNo
        {
            get { return lblNationalNoValue.Text; }
            set { lblNationalNoValue.Text = value; }
        }
        public string Gender
        {
            get { return lblGenderValue.Text; }
            set { lblGenderValue.Text = value; }
        }
        public string Email
        {
            get { return lblEmailValue.Text; }
            set { lblEmailValue.Text = value; }
        }
        public string Address
        {
            get { return lblAddressValue.Text; }
            set { lblAddressValue.Text = value; }
        }
        public string DateOfBirth
        {
            get { return lblDateOfBirthValue.Text; }
            set { lblDateOfBirthValue.Text = value; }
        }
        public string Phone
        {
            get { return lblPhoneNumberValue.Text; }
            set { lblPhoneNumberValue.Text = value; }
        }
        public string Country
        {
            get { return lblCountryValue.Text; }
            set { lblCountryValue.Text = value; }
        }
        public Image PersonImage
        {
            get { return pbPersonImage.Image; }
            set { pbPersonImage.Image = value; }
        }


        public usrCtrlPersonInfoCard() : this(0)
        {
            InitializeComponent();
        }
        public usrCtrlPersonInfoCard(int personID)
        {
            InitializeComponent();
            PersonID = personID.ToString();
            FillPersonInfo(personID);
            // Wireup the close button event
            btnClose.Click += (s, e) => OnCloseClicked?.Invoke(this, EventArgs.Empty);
        }
        // Helper method to load person image from a file path
        public void LoadPersonImage(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
            {
                // Set a default image if path is invalid
                if(Gender == "Male")
                    pbPersonImage.Image = DVLD.Properties.Resources.DefaultMan;
                else
                    pbPersonImage.Image = DVLD.Properties.Resources.DefaultWoman;
                return;
            }

            try
            {
                Image image = Image.FromFile(imagePath);
                pbPersonImage.Image = image;
                pbPersonImage.ImageLocation = imagePath;
            }
            catch
            {
                // If loading fails, use default image
                if (Gender == "Male")
                    pbPersonImage.Image = DVLD.Properties.Resources.DefaultMan;
                else
                    pbPersonImage.Image = DVLD.Properties.Resources.DefaultWoman;
            }
        }

        // Method to populate all fields from a Person object
        public void FillPersonInfo(int personID)
        {
            clsPerson person = clsPeopleBusinessLayer.GetPersonByID(personID);
            if (person == null)
                return;
            PersonID = person.PersonID.ToString();
            FullName = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            NationalNo = person.NationalNo;
            Gender = person.Gender ? "Female" : "Male";
            Email = person.Email;
            Address = person.Address;
            DateOfBirth = person.DateOfBirth.ToShortDateString();
            Phone = person.Phone;
            Country = person.Country?.CountryName ?? "Unknown";

            if (!string.IsNullOrEmpty(person.ImagePath))
            {
                LoadPersonImage(person.ImagePath);
            }
        }

        private void linklabelEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_EditPersonForm editForm = new Add_EditPersonForm(enFormMode.Update, Convert.ToInt32(PersonID));
            editForm.PersonSavedToDataBase += RefreshPersonDetails_OnSave;
            editForm.ShowDialog();
        }

        private void RefreshPersonDetails_OnSave(object sender, EventArgs e)
        {
            FillPersonInfo(Convert.ToInt32(PersonID)); // Person Details form refresh
        }
    }
}
