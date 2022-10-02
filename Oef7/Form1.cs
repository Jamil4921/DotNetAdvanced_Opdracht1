namespace Oef7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(Number.Text);
            int som = 0;

            for(int i = 0; i <= n; i++)
            {
                som = som + i;
            }

            Display.Text = som.ToString();
        }
    }
}