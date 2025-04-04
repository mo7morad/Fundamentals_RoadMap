using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class frmListContacts : Form
    {
        public frmListContacts()
        {
            InitializeComponent();
        }

        private void _RefreshContactsList()
        {
            dgvAllContacts.DataSource = clsContact.GetAllContacts();
        }

       

        private void dgvAllContacts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          //  MessageBox.Show(dgvAllContacts.CurrentRow.Cells[0].Value.ToString());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            frmAddEditContact frm = new frmAddEditContact((int) dgvAllContacts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            
            _RefreshContactsList();


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          if(  MessageBox.Show("Are you sure you want to delete contact [" + dgvAllContacts.CurrentRow.Cells[0].Value + "]","Confirm Delete",MessageBoxButtons.OKCancel)==DialogResult.OK)

            {

                //Perform Delele and refresh
               if( clsContact.DeleteContact((int)dgvAllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefreshContactsList();
                } 

               else
                    MessageBox.Show("Contact is not deleted.");

            }
          

        }

        private void frmListContacts_Load(object sender, EventArgs e)
        {

            _RefreshContactsList();


        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact(-1);
            frm.ShowDialog();
            _RefreshContactsList();
        }
    }
}
