using BusinessLayer;
using DVLD_Entities.Enums;
using Entities;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Add_EditPersonForm : Form
    {
        // Events
        public event EventHandler<EventArgs> PersonAddedToDatabase;
        public Add_EditPersonForm(enFormMode formMode, int personID=-1)
        {
            InitializeComponent(formMode, personID);
            // Subscribe to the OnSave, OnClose events
            usrCtrlAdd_EditPerson.OnSave += AddNewPerson_OnSave;
            usrCtrlAdd_EditPerson.OnClose += AddNewPerson_OnClose;
        }
        private void AddNewPerson_OnSave(object sender, EventArgs e)
        {
            string nationalNo = usrCtrlAdd_EditPerson.NationalNumber;
            string firstName = usrCtrlAdd_EditPerson.FirstName;
            string secondName = usrCtrlAdd_EditPerson.SecondName;
            string thirdName = usrCtrlAdd_EditPerson.ThirdName;
            string lastName = usrCtrlAdd_EditPerson.LastName;
            DateTime dateOfBirth = usrCtrlAdd_EditPerson.DateOfBirth;
            bool gender = Convert.ToBoolean(usrCtrlAdd_EditPerson.Gender == 'M' ? 0 : 1);
            string address = usrCtrlAdd_EditPerson.Address;
            string phone = usrCtrlAdd_EditPerson.Phone;
            string country = usrCtrlAdd_EditPerson.Country;
            string email = usrCtrlAdd_EditPerson.Email;
            string imagePath = usrCtrlAdd_EditPerson.ImagePath;

            // create the person object
            clsPerson p = new clsPerson(nationalNo, firstName, secondName, thirdName, lastName,
                                        dateOfBirth, gender, address, phone, country, email, imagePath);

            int personID = clsPeopleBusinessLayer.AddNewPerson(p);
            if (personID > 0)
            {
                usrCtrlAdd_EditPerson.PersonID = personID.ToString();
                MessageBox.Show("Person added successfully with ID: " + personID, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add person.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Firing the event.
            PersonAddedToDatabase?.Invoke(this, EventArgs.Empty);
        }
        private void AddNewPerson_OnClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}