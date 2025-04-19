using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class addNewPersonForm : Form
    {
        // Events
        public event EventHandler<EventArgs> PersonAddedToDatabase;

        public addNewPersonForm()
        {
            InitializeComponent();
            // Subscribe to the OnSave event
            usrCtrlAddNewPerson.OnSave += AddNewPerson_OnSave;
        }

        private void AddNewPerson_OnSave(object sender, EventArgs e)
        {
            string nationalNo = usrCtrlAddNewPerson.NationalNumber;
            string firstName = usrCtrlAddNewPerson.FirstName;
            string secondName = usrCtrlAddNewPerson.SecondName;
            string thirdName = usrCtrlAddNewPerson.ThirdName;
            string lastName = usrCtrlAddNewPerson.LastName;
            DateTime dateOfBirth = usrCtrlAddNewPerson.DateOfBirth;
            bool gender = Convert.ToBoolean(usrCtrlAddNewPerson.Gender == 'M' ? 0 : 1);
            string address = usrCtrlAddNewPerson.Address;
            string phone = usrCtrlAddNewPerson.Phone;
            string country = usrCtrlAddNewPerson.Country;
            string email = usrCtrlAddNewPerson.Email;
            string imagePath = usrCtrlAddNewPerson.ImagePath;

            // create the person object
            clsPerson p = new clsPerson(nationalNo, firstName, secondName, thirdName, lastName,
                                        dateOfBirth, gender, address, phone, country, email, imagePath);

            int personID = clsPeopleBusinessLayer.AddNewPerson(p);
            if (personID > 0)
            {
                usrCtrlAddNewPerson.PersonID = personID.ToString();
                MessageBox.Show("Person added successfully with ID: " + personID, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add person.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Firing the event.
            PersonAddedToDatabase?.Invoke(this, EventArgs.Empty);
        }

    }
}
