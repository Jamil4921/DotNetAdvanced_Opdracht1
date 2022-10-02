namespace oef1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string naam = Environment.UserName;
            string time = DateTime.Now.ToShortTimeString();
            string datum = DateTime.Now.ToShortDateString();
            MessageBox.Show("Hello " + naam + ". Het is " + time + " op " + datum);
        }
    }
}