namespace Onyx
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            bool createdNew;
            using (Mutex mutex = new Mutex(true, "Onyx", out createdNew))
            {
                if (!createdNew)
                {
                    // Mutex already exists — meaning another instance is running
                    return; // Exit this new instance
                }
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Main());
            }
        }
    }
}