namespace CS311_Project3_JFV
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }//end constructor

        private void btnCalculate_Click(object sender, EventArgs e)
        {
         
            summarize();
        }//end btnCalculate_Click

        private void summarize()
        {
            rtfOrderSummary.Clear();
            String dataSize = cboSize.GetItemText(cboSize.SelectedItem);
            String dataCrust = "";
            float toppingsCost = 0.00f;
            float sizeCost = 0.00f;
            rtfOrderSummary.SelectionFont = new Font("Arial", 10);
            rtfOrderSummary.SelectionColor = Color.Black;

            if (dataSize == "Small")
            {
                sizeCost = 2.00f;
            }
            else if (dataSize == "Medium")
            {
                sizeCost = 5.00f;
            }
            else if (dataSize == "Large")
            {
                sizeCost = 10.00f;
            }
            else if (dataSize == "X-Large")
            {
                sizeCost = 15.00f;
            }
            else if (dataSize == "Ginormous")
            {
                sizeCost = 20.00f;
            }
           
            if (rdoThin.Checked)

                dataCrust = "Thin";

            else if (rdoThick.Checked)
                dataCrust = "Thick";

            else if (rdoRegular.Checked)
                dataCrust = "Regular";

            rtfOrderSummary.SelectedText = "You ordered a " + dataSize + " pizza with " + dataCrust + " crust and the following toppings: " + "\n";
            rtfOrderSummary.SelectedText = "";

            rtfOrderSummary.SelectionBullet = true;

            if (ckbPepperoni.Checked)
            { 
                rtfOrderSummary.SelectedText = "Pepperoni\n";
                toppingsCost += 2.00f;
            }
            if (ckbSausage.Checked)
            {
                rtfOrderSummary.SelectedText = "Sausage\n";
                toppingsCost += 2.00f;
            }
            if (ckbCanadianBacon.Checked)
            {
                rtfOrderSummary.SelectedText = "Canadian Bacon\n";
                toppingsCost += 2.00f;
            }
            if (ckbSpicyItalianSausage.Checked)
            {
                rtfOrderSummary.SelectedText = "Spicy Italian Sausage\n";
                toppingsCost += 2.00f;
            }
            if (ckbOnion.Checked)
            {
                rtfOrderSummary.SelectedText = "Onion\n";
                toppingsCost += 1.00f;
            }
            if (ckbGreenPepper.Checked)
            {
                rtfOrderSummary.SelectedText = "Green Pepper\n";
                toppingsCost += 1.00f;
            }
            if (ckbBlackOlives.Checked)
            {
                rtfOrderSummary.SelectedText = "Black Olives\n";
                toppingsCost += 1.00f;
            }
            if (ckbGreenOlives.Checked)
            {
                rtfOrderSummary.SelectedText = "Green Olives\n";
                toppingsCost += 1.00f;
            }
            if (ckbBananaPeppers.Checked)
            {
                rtfOrderSummary.SelectedText = "Banana Peppers\n";
                toppingsCost += 1.00f;
            }
            if (ckbJalepeno.Checked)
            {
                rtfOrderSummary.SelectedText = "Jalapeno\n";
                toppingsCost += 1.00f;
            }
            if (ckbExtraCheese.Checked)
            {
                rtfOrderSummary.SelectedText = "Extra Cheese\n";
                toppingsCost += 1.00f;
            }
            if (ckbMushroom.Checked)
            {
                rtfOrderSummary.SelectedText = "Mushroom\n";
                toppingsCost += 1.00f;
            }

            rtfOrderSummary.SelectionBullet = false;
            //now calculate and show subtotal,tax,and total
            float subTotal = toppingsCost + sizeCost;
            txtSubTotal.Text = subTotal.ToString("0.00");
          
            float tax = subTotal * 0.06f;
            txtTax.Text = tax.ToString("0.00");

            float total = subTotal + tax;
            txtTotal.Text = total.ToString("0.00");

        }//end summarize()

     

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            String dataSize = cboSize.GetItemText(cboSize.SelectedItem);
            rtfOrderSummary.SelectionFont = new Font("Arial", 10);
            rtfOrderSummary.SelectionColor = Color.Black;

        }//end  cboSize_SelectedIndexChanged

    }//emd frmMain

}//end namespace
