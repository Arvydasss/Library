namespace Library
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyApplicationContext context = new MyApplicationContext();
            Application.Run(context);
        }

        public class MyApplicationContext : ApplicationContext
        {
            private Login form = new Login();

            public MyApplicationContext()
            {
                form = new Login();
                form.Show();
            }
        }
    }
}