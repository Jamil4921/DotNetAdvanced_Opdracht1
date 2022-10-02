namespace oef6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price1 = Double.Parse(Price1.Text);
            double price2 = Double.Parse(Price2.Text);
            double price3 = Double.Parse(Price3.Text);
            double price4 = Double.Parse(Price4.Text);

            double quantity1 = Double.Parse(Quantity1.Text);
            double quantity2 = Double.Parse(Quantity2.Text);
            double quantity3 = Double.Parse(Quantity3.Text);
            double quantity4 = Double.Parse(Quantity4.Text);

            double exactPrice1 = price1 * quantity1;
            double exactPrice2 = price2 * quantity2;
            double exactPrice3 = price3 * quantity3;
            double exactPrice4 = price4 * quantity4;

            Extprice1.Text = exactPrice1.ToString();
            Extprice2.Text = exactPrice2.ToString();
            Extprice3.Text = exactPrice3.ToString();
            Extprice4.Text = exactPrice4.ToString();

            double shipping = 0;

            double sum = exactPrice1 + exactPrice2 + exactPrice3 + exactPrice4;

          
            Subtotal.Text = sum.ToString();




            if (sum <= 20.00)
            {
                shipping = 5.00;
                Shipping.Text = shipping.ToString();

            }else if(sum >= 20.00 && sum <= 50.00){

                shipping = 7.00;
                Shipping.Text = shipping.ToString();

            }else if(sum >= 51.00 && sum <= 75.00)
            {
                shipping = 10.00;
                Shipping.Text = shipping.ToString();

            }else if(sum >= 75.00)
            {
                shipping = 0;
                Shipping.Text = shipping.ToString();
            }

            double tax = sum * 7 /100;
            Salestax.Text = tax.ToString();

            double total = sum + tax + shipping;
            Grandtotal.Text = total.ToString();


        }
    }
}