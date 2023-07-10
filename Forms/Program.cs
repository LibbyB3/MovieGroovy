namespace Forms
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

            AppLibrary.GlobalConfig.InitializeConnection(); //initialize the connection between sql and app

            Application.Run(new LandingPage());
        }
    }
}