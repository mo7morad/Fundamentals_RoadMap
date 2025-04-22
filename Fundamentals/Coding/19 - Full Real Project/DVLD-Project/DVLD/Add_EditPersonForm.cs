using BusinessLayer;
using DVLD_Entities.Enums;
using Entities;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Add_EditPersonForm : Form
    {
        public event EventHandler<EventArgs> PersonSavedToDataBase;
        public enFormMode FormMode;
        public int PersonID { get; set; }

        public Add_EditPersonForm(enFormMode formMode, int personID = -1)
        {
            FormMode = formMode;
            PersonID = personID;

            InitializeComponent(formMode, personID);

            usrCtrlAdd_EditPerson.OnSave += Form_OnSave;
            usrCtrlAdd_EditPerson.OnClose += Form_OnClose;
        }

        private (int personID, string errorMessage) AddNewPersonToDataBase()
        {
            clsPerson p = BuildPersonFromForm();

            string errorMessage = string.Empty;
            int personID = clsPeopleBusinessLayer.AddNewPerson(p, ref errorMessage);

            return (personID, errorMessage);
        }

        private (bool result, string errorMessage) UpdatePersonInDataBase()
        {
            clsPerson p = BuildPersonFromForm();
            p.PersonID = this.PersonID;

            string errorMessage = string.Empty;
            bool result = clsPeopleBusinessLayer.UpdatePerson(p, ref errorMessage);

            return (result, errorMessage);
        }

        private clsPerson BuildPersonFromForm()
        {
            string nationalNo = usrCtrlAdd_EditPerson.NationalNumber;
            string firstName = usrCtrlAdd_EditPerson.FirstName;
            string secondName = usrCtrlAdd_EditPerson.SecondName;
            string thirdName = usrCtrlAdd_EditPerson.ThirdName;
            string lastName = usrCtrlAdd_EditPerson.LastName;
            DateTime dateOfBirth = usrCtrlAdd_EditPerson.DateOfBirth;
            bool gender = usrCtrlAdd_EditPerson.Gender == true ? true : false;
            string address = usrCtrlAdd_EditPerson.Address;
            string phone = usrCtrlAdd_EditPerson.Phone;

            string countryName = usrCtrlAdd_EditPerson.Country;
            int countryID = clsCountriesBusinessLayer.GetCountryID(countryName);
            Entities.clsCountry country = new Entities.clsCountry(countryID, countryName);

            string email = usrCtrlAdd_EditPerson.Email;
            string imagePath = usrCtrlAdd_EditPerson.ImagePath;

            return new clsPerson(nationalNo, firstName, secondName, thirdName, lastName,
                                 dateOfBirth, gender, address, phone, country, email, imagePath);
        }

        private void Form_OnSave(object sender, EventArgs e)
        {
            if (FormMode == enFormMode.AddNew)
            {
                var addResult = AddNewPersonToDataBase();
                if (addResult.personID > 0)
                {
                    usrCtrlAdd_EditPerson.PersonID = addResult.personID.ToString();
                    MessageBox.Show("Person added successfully with ID: " + addResult.personID,
                                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string message = string.IsNullOrEmpty(addResult.errorMessage)
                        ? "Failed to add person."
                        : "Failed to add person:\n" + addResult.errorMessage;

                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (FormMode == enFormMode.Update)
            {
                var updateResult = UpdatePersonInDataBase();
                if (updateResult.result)
                {
                    MessageBox.Show("Person updated successfully!",
                                    "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string message = string.IsNullOrEmpty(updateResult.errorMessage)
                        ? "Failed to update person."
                        : "Failed to update person:\n" + updateResult.errorMessage;

                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PersonSavedToDataBase?.Invoke(this, EventArgs.Empty);
        }

        private void Form_OnClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
