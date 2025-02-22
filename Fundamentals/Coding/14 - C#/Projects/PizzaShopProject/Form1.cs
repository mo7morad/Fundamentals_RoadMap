using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {
            
            UpdateTotalPrice();

            switch(true)
            {
                case true when rbSamll.Checked:
                    lblSize.Text = "Small";
                    break;
                case true when rbMedium.Checked:
                    lblSize.Text = "Medium";
                    break;
                case true when rbLarge.Checked:
                    lblSize.Text = "Large";
                    break;
            }

        }

        void UpdateToppings()
        {

            UpdateTotalPrice();

            string sToppings = "";

            if (chkChicken.Checked)
            {
                sToppings += "Chicken, ";
            }
            if (chkMixCheese.Checked)
            {
                sToppings += "Mix Cheese, ";
            }
            if (chkMushrooms.Checked)
            {
                sToppings += "Mushrooms, ";
            }
            if (chkTuna.Checked)
            {
                sToppings += "Tuna, ";
            }
            if (chkBeef.Checked)
            {
                sToppings += "Beef, ";
            }
            if (chkVegetables.Checked)
            {
                sToppings += "Vegetables, ";
            }

            lblToppings.Text = sToppings;
            

        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked) 
            {
                lblCrustType.Text = "Think Crust";
                return;
            }

            else if (rbStuffedCrust.Checked)
            {
                lblCrustType.Text = "Stuffed Crust";
                return;
            }


        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In.";
                return;
            }

            if (rbTakeAway.Checked)
            {
                lblWhereToEat.Text = "Take Away.";
                return;
            }

        }

        float GetSelectedSizePrice()
        {
            if (rbSamll.Checked)
           
                return Convert.ToSingle( rbSamll.Tag);

             else if (rbMedium.Checked)

                return Convert.ToSingle( rbMedium.Tag);

            else 
                return Convert.ToSingle( rbLarge.Tag);

        }

        float  CalculateToppingsPrice()
        {

           
            float ToppingsTotalPrice = 0;

            if (chkChicken.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle( chkChicken.Tag) ;
            }


            if (chkMixCheese.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMixCheese.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkTuna.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTuna.Tag);
            }

            if (chkBeef.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkBeef.Tag);
            }

            if (chkVegetables.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkBeef.Tag);
            }



            return ToppingsTotalPrice;



        }

        float GetSelectedCrutPrice()
        {
            if (rbThinCrust.Checked)

                return Convert.ToSingle( rbThinCrust.Tag);

            else
                return Convert.ToSingle(rbStuffedCrust.Tag);

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice();
        }

        void UpdateTotalPrice()
        {

            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();

        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        void ResetForm()
        {
           
            //reset Groups
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;
           
            //reset Size
            rbMedium.Checked = true;
            
            //reset Toppings.
            chkChicken.Checked = false;
            chkMixCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkTuna.Checked = false;
            chkBeef.Checked = false; 
            chkVegetables.Checked = false;
            
            //reset CrustType
            rbThinCrust.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrderPizza.Enabled = true;

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            { 
                MessageBox.Show("Order Placed Successfully", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;

            }
            else

                MessageBox.Show("Update your order", "Update", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbSamll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chckGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
