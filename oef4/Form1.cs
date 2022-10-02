namespace oef4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Extprice_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double quantity = Double.Parse(Quantity.Text);
            double prijs = Double.Parse(Price.Text);
            double total = quantity * prijs;
            Extprice.Text = total.ToString();

            double quantity2 = Double.Parse(Quantity2.Text);
            double prijs2 = Double.Parse(Price2.Text);
            double total2 = quantity2 * prijs2;
            Extprice2.Text = total2.ToString();

            double quantity3 = Double.Parse(Quantity3.Text);
            double prijs3 = Double.Parse(Price3.Text);
            double total3 = quantity3 * prijs3;
            Extprice3.Text = total3.ToString();

            double quantity4 = Double.Parse(Quantity4.Text);
            double prijs4 = Double.Parse(Price4.Text);
            double total4 = quantity4 * prijs4;
            Extprice4.Text = total4.ToString();

            double subtotal = total + total2 + total3 + total4;
            sum.Text = subtotal.ToString();


            double tax = Double.Parse(taxRate.Text);
            double taxrate = subtotal * tax;
            saleTax.Text = taxrate.ToString();

            double shipping = Double.Parse(Ship.Text);
            Ship.Text = shipping.ToString();

            double grandtotal = subtotal + taxrate + shipping;
            grandTotal.Text = grandtotal.ToString();


        }

        private void Extprice_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Quantity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}