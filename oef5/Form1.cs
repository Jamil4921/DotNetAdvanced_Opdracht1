namespace oef5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void Celsius_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Celsius_btn_Click(object sender, EventArgs e)
        {
           
          
            if(Celsius.Text == "")
            {
                string cel = Convert.ToString(Celsius.Text);
                MessageBox.Show("Value cant be null");
            }
            else
            {
                double cel = Convert.ToDouble(Celsius.Text);
                cel = cel * 9/5 + 32;
                Fahrenheit.Text = cel.ToString();
            }
        }

        private void Fahrenheit_btn_Click(object sender, EventArgs e)
        {
            if (Fahrenheit.Text == "")
            {
                string fah = Convert.ToString(Fahrenheit.Text);
                MessageBox.Show("Value cant be null");
            }
            else
            {
                double fah = Convert.ToDouble(Fahrenheit.Text);
                fah = (fah -  32) * 5/9;
                Celsius.Text = fah.ToString();
            }
        }
    }
}