namespace oef2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

            bool result;

            int som = 12345 * 54321;
            string res1 = som.ToString();
            resultaat1.Text = res1;

            int som2 = 22222 * 33333;
            string res2 = som2.ToString();
            resultaat2.Text = res2;

            if(som > som2)
            {
                result = true;
                string endResult = result.ToString();
                resultaat3.Text = endResult;
            }
            else
            {
                result = false;
                string endResult = result.ToString();
                resultaat3.Text = endResult;
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getal1_Click(object sender, EventArgs e)
        {
           
        }
    }
}