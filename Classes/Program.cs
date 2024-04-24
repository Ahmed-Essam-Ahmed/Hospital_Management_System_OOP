using System.Runtime.CompilerServices;


namespace Hospital_Managment_System_OOP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login_Page());
        }

    }
}