namespace LunchOrder
{
    public partial class frmLunchOrder : Form
    {
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbxMainCourse_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoHamburger.Checked = true;
            clearTotal();
            clearAddOns();


        }

        private void clearTotal()
        {
            txtOrderTotal.Text = "";
            txtSalesTax.Text = "";
            txtSubTotal.Text = "";


        }


        private void clearAddOns()
        {
            ckbFrenchFries.Checked = false;
            ckbKetMusMayo.Checked = false;
            ckbLetTomOnions.Checked = false;

        }

        private void gbxAddOns_Enter(object sender, EventArgs e)
        {
            clearTotal();
            total = 0;
            addOnsPrice = 0;
        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            //clear checkedbox and total
            clearAddOns();
            clearTotal();

            //change text of the ckbox
            if (rdoPizza.Checked == true)
            {
                ckbLetTomOnions.Text = "Pepperoni";
                ckbKetMusMayo.Text = "Sausage";
                ckbFrenchFries.Text = "Olives";
                gbxAddOns.Text = "Add-on Items ($.75 each)";
            }
        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            // clear checkedbox and total
            clearAddOns();
            clearTotal();

            // change text of the checkbox
            if (rdoHamburger.Checked == true)
            {
                ckbKetMusMayo.Text = "Ketchup, Mustard, and Mayo";
                ckbLetTomOnions.Text = "Lettuce, Tomato, and Onions";
                ckbFrenchFries.Text = "French Fries";

                gbxAddOns.Text = "Add-on Items ($1.25 each)";
            }
        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            // clear checkedbox and total
            clearAddOns();
            clearTotal();


            // change text of the checkbox
            if (rdoSalad.Checked == true)
            {
                ckbKetMusMayo.Text = "Croutons";
                ckbLetTomOnions.Text = "Bacon Bits";
                ckbFrenchFries.Text = "Bread Sticks";
                gbxAddOns.Text = "Add-on Items ($.50 each)";

            }
        }

        //GLOBAL VARIABLES!
        //const for tax charge
        const decimal taxCharged = 0.0775m;

        //declaring and initializing 
        decimal total = 0m;
        decimal subTotal = 0m;
        decimal tax = 0m;
        decimal price = 0m;
        decimal addOnsPrice = 0m;


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //forHamburgerCalculation for menus
            forHamburgerCalculation();
            forPizzaCalculation();
            forSaladCalculation();

        }

        private void forHamburgerCalculation()
        {
            // if hamburger is chosen, set price to $7.95 
            if (rdoHamburger.Checked == true)
            {
                price = 7.95m;


                // if add ons are checked add 1.25$ per each
                if ((ckbKetMusMayo.Checked == true))
                {
                    addOnsPrice += 1.25m;

                }
                if (ckbFrenchFries.Checked == true)
                {
                    addOnsPrice += 1.25m;
                }
                if (ckbLetTomOnions.Checked == true)
                {
                    addOnsPrice += 1.25m;
                }

                //calculating totalprices and tax
                subTotal = price + addOnsPrice;
                tax = subTotal * taxCharged;
                total = subTotal + tax;


                //display prices and tax
                txtSubTotal.Text = subTotal.ToString("c");
                txtSalesTax.Text = tax.ToString("c");
                txtOrderTotal.Text = total.ToString("c");
            }

        }

        private void forPizzaCalculation()
        {
            // if pizza is chosen, set price to 6.95$ 
            if (rdoPizza.Checked == true)
            {
                price = 6.95m;


                // if add on/s are checked add .75$ per each
                if ((ckbKetMusMayo.Checked == true))
                {
                    addOnsPrice += 0.75m;

                }
                if (ckbFrenchFries.Checked == true)
                {
                    addOnsPrice += 0.75m;
                }
                if (ckbLetTomOnions.Checked == true)
                {
                    addOnsPrice += 0.75m;
                }

                //calculating totalprices and tax
                subTotal = price + addOnsPrice;
                tax = subTotal * taxCharged;
                total = subTotal + tax;

                //show calculation prices
                txtSubTotal.Text = subTotal.ToString("c");
                txtSalesTax.Text = tax.ToString("c");
                txtOrderTotal.Text = total.ToString("c");
            }

        }
        private void forSaladCalculation()
        {
            // if salad is chosen, set price to 6.75$
            if (rdoSalad.Checked == true)
            {
                price = 6.75m;


                // if add on/s are/is checked add .50$ per each
                if ((ckbKetMusMayo.Checked == true))
                {
                    addOnsPrice += 0.50m;

                }
                if (ckbFrenchFries.Checked == true)
                {
                    addOnsPrice += 0.50m;
                }
                if (ckbLetTomOnions.Checked == true)
                {
                    addOnsPrice += 0.50m;
                }

                //calculating totalprices and tax
                subTotal = price + addOnsPrice;
                tax = subTotal * taxCharged;
                total = subTotal + tax;


                //display totals
                txtSubTotal.Text = subTotal.ToString("c");
                txtSalesTax.Text = tax.ToString("c");
                txtOrderTotal.Text = total.ToString("c");
            }
        }
    }
}

