using DVLD_Entities.Enums;

namespace DVLD
{
    partial class Add_EditPersonForm
    {
        private void InitializeComponent(enFormMode formMode, int personID=-1)
        {
            this.usrCtrlAdd_EditPerson = new usrCtrlPerson(formMode, personID);
            this.SuspendLayout();
            // 
            // usrCtrlAdd_EditPerson (Control Add New Setup)
            // 
            if (formMode == enFormMode.AddNew)
            {
                this.usrCtrlAdd_EditPerson.Address = "";
                this.usrCtrlAdd_EditPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.usrCtrlAdd_EditPerson.Country = "";
                this.usrCtrlAdd_EditPerson.DateOfBirth = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
                this.usrCtrlAdd_EditPerson.Dock = System.Windows.Forms.DockStyle.Fill;
                this.usrCtrlAdd_EditPerson.Email = "";
                this.usrCtrlAdd_EditPerson.FirstName = "";
                this.usrCtrlAdd_EditPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
                this.usrCtrlAdd_EditPerson.Gender = false;
                this.usrCtrlAdd_EditPerson.ImagePath = null;
                this.usrCtrlAdd_EditPerson.LastName = "";
                this.usrCtrlAdd_EditPerson.Location = new System.Drawing.Point(0, 0);
                this.usrCtrlAdd_EditPerson.Name = "usrCtrlAdd_EditPerson";
                this.usrCtrlAdd_EditPerson.NationalNumber = "";
                this.usrCtrlAdd_EditPerson.PersonID = "N/A";
                this.usrCtrlAdd_EditPerson.Phone = "";
                this.usrCtrlAdd_EditPerson.SecondName = "";
                this.usrCtrlAdd_EditPerson.Size = new System.Drawing.Size(691, 381);
                this.usrCtrlAdd_EditPerson.TabIndex = 0;
                this.usrCtrlAdd_EditPerson.ThirdName = "";
            }
            // 
            // Add_EditPersonForm
            // 
            this.ClientSize = new System.Drawing.Size(691, 381);
            this.Controls.Add(this.usrCtrlAdd_EditPerson);
            this.Name = "Add_EditPersonForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            if(formMode == enFormMode.Update)
                this.Text = "Update Person";
            else
                this.Text = "Add New Person";
            this.ResumeLayout(false);

        }

        private usrCtrlPerson usrCtrlAdd_EditPerson;
    }
}